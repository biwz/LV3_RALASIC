using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv3_ralasic
{
    class Program
    {
        static void Main(string[] args)

        {   //prvi zadatak
            //Dataset dataFromCSV = new Dataset("CSV.csv");
            //Console.WriteLine(dataFromCSV.ToString());
            //Dataset dataClone = (Dataset)dataFromCSV.Clone();
            //Console.WriteLine(dataClone.ToString());
            //dataFromCSV.ClearData();
            //Console.WriteLine(dataFromCSV.ToString());
            //Console.WriteLine(dataClone.ToString());

            //drugi zadatak
            //double[][] doubleMatrix = ArrayGenerator.GetInstance().generateRandomDoubleMatrix(4, 34);
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //        Console.Write(doubleMatrix[i][j] + "    ");
            //    Console.WriteLine("\n");
            //}

            //treci zadatak
            //Logger logger = Logger.GetInstance();
            //logger.setFilePath("lv3TestFile.txt");
            //logger.Log("First Test\n");
            //logger.Log("Second test\n");

            //cetvrti zadatak
            //ConsoleNotification consoleNotification = new ConsoleNotification("Me","Console Notification","Something to be writen!",DateTime.Now,Category.INFO,ConsoleColor.Blue);
            //NotificationManager notificationmanager = new NotificationManager();
            //notificationmanager.Display(consoleNotification);

            //peti zadatak
            NotificationBuilder notificationBuilder = new NotificationBuilder();
            notificationBuilder.
                SetAuthor("Me").
                SetText("Something to be writen!").
                SetTime(DateTime.Now).
                SetTitle("Console Notification").
                SetColor(ConsoleColor.Red).
                SetLevel(Category.ALERT);

            ConsoleNotification consoleNotification = notificationBuilder.Build();
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Display(consoleNotification);

        }
    }
}

