using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DogAgeCalculator.Entities;


namespace DogAgeCalculator.DAL
{
    public class DogDataDAL
    {


        private static string _reportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DogAgeReport.docx");
        private static string _recordPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DogRecords.txt");

        /// <summary>
        /// Retrieves all dog records stored in the local text file.
        /// </summary>
        /// <returns>A list of <see cref="DogData"/> objects. If the file is missing, returns an empty list.</returns>
        public static List<DogData> GetRecords()
        {
            List<DogData> list = new List<DogData>();

            if (!File.Exists(_recordPath))
            {
                return new List<DogData>();
            }

            using (StreamReader sr = new StreamReader(_recordPath))
            {
                string? line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split("|");

                    if (data.Length == 7)
                    {
                        DogData Obj = new DogData
                        {
                            OwnerName = data[0],
                            Name = data[1],
                            Breed = data[2],
                            Age = int.Parse(data[3]),
                            ConvertedAge = int.Parse(data[4]),
                            Weight = float.Parse(data[5]),
                            Date = DateTime.Parse(data[6])
                        };
                        list.Add(Obj);
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Stores a new record in both the .txt log and the .docx report.
        /// </summary>
        /// <param name="data">The <see cref="DogData"/> object containing the record information.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="data"/> is null.</exception>
        /// <exception cref="Exception">Thrown if there is an error accessing the file system.</exception>
        public static void SaveRecord(DogData data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("The data to be recorded cannot be null.");
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(_recordPath, true))
                {
                    sw.WriteLine($"{data.OwnerName} | {data.Name} | {data.Breed} | {data.Age} | {data.ConvertedAge} | {data.Weight} | {data.Date:g}");
                }

                if (!File.Exists(_reportPath))
                {
                    using (WordprocessingDocument docx = WordprocessingDocument.Create(_reportPath, WordprocessingDocumentType.Document))
                    {
                        docx.AddMainDocumentPart();
                        docx.MainDocumentPart!.Document = new Document(new Body());
                    }
                }

                using (WordprocessingDocument docx = WordprocessingDocument.Open(_reportPath, true))
                {
                    if (docx.MainDocumentPart!.Document == null)
                    {
                        docx.MainDocumentPart.Document = new Document(new Body());
                    }

                    Body body = docx.MainDocumentPart.Document!.Body!;

                    void AddField(string label, string value)
                    {
                        Paragraph p = new Paragraph();

                        Run rLabel = new Run(new RunProperties(new Bold()), new Text(label) { Space = SpaceProcessingModeValues.Preserve });
                        Run rValue = new Run(new Text(value));

                        if (rValue == null)
                        {
                            throw new ArgumentNullException("the value is null");
                        }

                        p.Append(rLabel);
                        p.Append(rValue);
                        body.Append(p);
                    }

                    AddField("Owner's name: ", data.OwnerName);
                    AddField("Dog's name: ", data.Name);
                    AddField("Dog breed: ", data.Breed);
                    AddField("Dog's age: ", data.Age.ToString() + " years old");
                    AddField("Converted age: ", data.ConvertedAge.ToString() + " human years");
                    AddField("Dog's weight: ", data.Weight + " kg");
                    AddField("Date: ", data.Date.ToString("g"));
                    body.Append(new Paragraph(new Run(new Text("────────────────────────"))));

                    docx.MainDocumentPart.Document.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error registering the data.", ex);
            }
        }
    }
}
