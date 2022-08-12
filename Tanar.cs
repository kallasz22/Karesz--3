using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "palya71.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 0, 0, 0, 0, 0, 1, 15, 1);


            int calib_min = 10;
            int calib_max = 10;

            Robot anti1 = new Robot("anti1", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 17, 9, 2);

            anti1.Feladat = delegate ()
            {
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < random.Next(calib_min, calib_max); j++)
                    {
                        anti1.Várj();
                    }
                    anti1.Lőjj();
                }
            };

            Robot anti2 = new Robot("anti2", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 18, 25, 0);

            anti2.Feladat = delegate ()
            {
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < random.Next(calib_min, calib_max); j++)
                    {
                        anti2.Várj();
                    }
                    anti2.Lőjj();
                }
            };

            Robot anti3 = new Robot("anti3", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 19, 1, 2);

            anti3.Feladat = delegate ()
            {
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < random.Next(calib_min, calib_max); j++)
                    {
                        anti3.Várj();
                    }
                    anti3.Lőjj();
                }
            };

            Robot anti4 = new Robot("anti4", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 20, 29, 0);

            anti4.Feladat = delegate ()
            {
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < random.Next(calib_min, calib_max); j++)
                    {
                        anti4.Várj();
                    }
                    anti4.Lőjj();
                }
            };

            Robot anti5 = new Robot("anti5", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 21, 1, 2);

            anti5.Feladat = delegate ()
            {
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < random.Next(calib_min, calib_max); j++)
                    {
                        anti5.Várj();
                    }
                    anti5.Lőjj();
                }
            };

            Robot anti6 = new Robot("anti6", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 22, 25, 0);

            anti6.Feladat = delegate ()
            {
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < random.Next(calib_min, calib_max); j++)
                    {
                        anti6.Várj();
                    }
                    anti6.Lőjj();
                }
            };

            Robot anti7 = new Robot("anti7", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 23, 9, 2);

            anti7.Feladat = delegate ()
            {
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < random.Next(calib_min, calib_max); j++)
                    {
                        anti7.Várj();
                    }
                    anti7.Lőjj();
                }
            };
        }
    }
}