using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serializer_Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookCollection = new List<Book>();

            #region Filling
            Book bookTemp = new Book();
            for (int i = 0; i < 5; i++)
            {
                bookTemp.Name = "Book " + i;
                bookTemp.Price = 1000 + i*2;
                bookTemp.Author = "Leha";
                bookTemp.Year = 2000 + i;
                bookCollection.Add(bookTemp);
            }
            #endregion

            #region FileWrite
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Book[] bookArray = bookCollection.ToArray();
            using (FileStream fs = new FileStream("Book.dat", FileMode.OpenOrCreate))
            {
                for (int i = 0; i < bookArray.Length; i++)
                {
                    binaryFormatter.Serialize(fs, bookArray[i]);
                }
            }
            Console.WriteLine("Объект успешно сериализован");
            #endregion

            #region FileRead
            List<Book> newBookCollection = new List<Book>();
            using (FileStream fs = new FileStream("Book.dat", FileMode.OpenOrCreate))
            {
                for (int i = 0; i < bookArray.Length; i++)
                {
                    Book newBook = binaryFormatter.Deserialize(fs) as Book;
                    newBookCollection.Add(newBook);
                }
            }
            bookCollection = newBookCollection;
            Console.WriteLine("Объект успешно десериализован");
            #endregion
            Book TestAttribute = new Book();
            TestAttribute.GetMessage();
            Console.ReadLine();
        }
    }
}
