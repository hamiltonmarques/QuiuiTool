using System;
using System.IO;
using Xceed.Words.NET;
using System.Drawing;

namespace TestProject
{
    /// <summary>
    /// Provides methods to add images and texts in Microsoft Word 2007/2010/2013 files.
    /// </summary>
    /// <remarks>
    /// The MIT License (MIT) Copyright (c) 2018 Hamilton Marques.
    /// Meet Hamilton Marques at http://bit.do/HamiltonLinkedIn
    /// </remarks>
    public class Docx
    {
        /// <summary>
        /// Directory where the Microsoft Word files are created and edited.
        /// </summary>
        private static string docxFolder = Quiui.docxFolder;

        /// <summary>
        /// Adds an image in a Microsoft Word file and then deletes permanently the image from its path.
        /// Creates a new Microsoft Word file if it does not exist.
        /// </summary>
        /// <param name="imagePath">Path of the image.</param>
        /// <param name="docxName">Name of the Microsoft Word file.</param>
        public static void AddImage(string imagePath, string docxName)
        {
            if (!Directory.Exists(docxFolder))
            {
                Quiui.CreateDocxFolder();
            }

            string docxPath = docxFolder + @"\" + docxName;

            DocX document = Document(docxPath);

            var image = document.AddImage(imagePath);

            Picture picture = image.CreatePicture(290, 600);

            var p = document.InsertParagraph();

            p.AppendPicture(picture);

            p.Append(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")).Font("Segoe UI").FontSize(10).Color(Color.FromArgb(160, 160, 160)).Alignment = Alignment.center;

            p.AppendLine();

            document.Save();
            document.Dispose();

            File.Delete(imagePath);
        }

        /// <summary>
        /// Adds a text in a Microsoft Word file.
        /// Creates a new Microsoft Word file if it does not exist.
        /// </summary>
        /// <param name="text">Text to be added.</param>
        /// <param name="align">Alignment of the text.</param>
        /// <param name="docxName">Name of the Microsoft Word file.</param>
        public static void AddText(string text, Alignment align, string docxName)
        {
            if (!Directory.Exists(docxFolder))
            {
                Quiui.CreateDocxFolder();
            }

            string docxPath = docxFolder + @"\" + docxName;

            DocX document = Document(docxPath);

            var p = document.InsertParagraph();

            p.Append(text).Font("Segoe UI").FontSize(10).Alignment = align;

            p.AppendLine();

            document.Save();
            document.Dispose();
        }

        /// <summary>
        /// Creates a Microsoft Word file and opens in background if it does not exist.
        /// Opens a Microsoft Word file in background if it exists.
        /// </summary>
        /// <param name="docxPath">Path of the Microsoft Word file.</param>
        /// <returns>The Microsoft Word file opened.</returns>
        private static DocX Document(string docxPath)
        {
            if (!File.Exists(docxPath))
            {
                return DocX.Create(docxPath);
            }
            else
            {
                return DocX.Load(docxPath);
            }
        }
    }
}