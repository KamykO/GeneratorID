namespace GeneratorID
{
    internal class ImageE
    {

        #region Others Value
        private Bitmap temp_A4ID; // A4 temp bitmap
        private int temp_A4IDint = 0; // A4 temp photos are on A4

        private int a4counter = 1; // how many a4 are saved
        #endregion
        #region Size
        private Size dimS = new Size(501, 325); // ID size 
        public Size DimS
        {
            get { return dimS; }
            set { dimS = value; }
        }
        #endregion
        #region Fonts
        // Fonts
        private Font fontName = new Font("Cambria", 26.0f, FontStyle.Bold);
        public Font FontName
        {
            get { return fontName; }
            set { fontName = value; Console.WriteLine("Font: Name: Update" + FontName.ToString()); }
        }
        private Font fontSecondName = new Font("Cambria", 13.0f, FontStyle.Bold);
        public Font FontSecondName
        {
            get { return fontSecondName; }
            set { fontSecondName = value; }
        }
        private Font fontClas = new Font("Cambria", 39.0f, FontStyle.Bold);
        public Font FontClas
        {
            get { return fontClas; }
            set { fontClas = value; }

        }
        // End of Fonts
        #endregion
        #region Points
        // Text Points XY
        private Point pointName = new Point(230, 115); //Cords of name
        public Point PointName
        {
            get { return pointName; }
            set { pointName = value; }
        }
        private Point pointSecondName = new Point(240, 175); //Cords of second name
        public Point PointSecondName
        {
            get { return pointSecondName; }
            set { pointSecondName = value; Console.WriteLine("pointscN = " + pointSecondName.ToString()); }
        }
        private Point pointClass = new Point(390, 240); //Cords of class
        public Point PointClass
        {
            get { return pointClass; }
            set { pointClass = value; }
        }
        #endregion
        #region Data of Link & Cords

        private Point pointOfFirstID = new Point(10, 10); //XY of first ID cords
        public Point PointOfFirstID
        { get { return pointOfFirstID; } set { pointOfFirstID = value; } }

        public ushort HowManyCardsonPage; // to do

        private ushort idsCounter = 1; //counter - how many Id's is on A4 (f() below)
        private Point nextPoint()
        { // need update and mods 
            Point point;
            if (idsCounter == maxIdOnPage)
            {
                idsCounter = 1;
            }
            switch (idsCounter)
            {
                case 1:
                    point = PointOfFirstID;
                    break;
                case 2:
                    point = new Point(PointOfFirstID.X + whiteSpaceX + dimS.Width, PointOfFirstID.Y);
                    break;
                case 3:
                    point = new Point(PointOfFirstID.X, PointOfFirstID.Y + whiteSpaceY + dimS.Height);
                    break;
                case 4:
                    point = new Point(PointOfFirstID.X + whiteSpaceX + dimS.Width, PointOfFirstID.Y + whiteSpaceY + dimS.Height);
                    break;
                case 5:
                    point = new Point(PointOfFirstID.X, PointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 2);
                    break;
                case 6:
                    point = new Point(PointOfFirstID.X + whiteSpaceX + dimS.Width, PointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 2);
                    break;
                case 7:
                    point = new Point(PointOfFirstID.X, PointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 3);
                    break;
                case 8:
                    point = new Point(pointOfFirstID.X + whiteSpaceX + dimS.Width, pointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 3);
                    break;
                case 9:
                    point = new Point(PointOfFirstID.X, PointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 4);
                    break;
                case 10:
                    point = new Point(pointOfFirstID.X + whiteSpaceX + dimS.Width, pointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 4);
                    break;
                case 11:
                    point = new Point(PointOfFirstID.X, PointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 5);
                    break;
                case 12:
                    point = new Point(pointOfFirstID.X + whiteSpaceX + dimS.Width, pointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 5);
                    break;
                default:
                    MessageBox.Show("Poop #1");
                    point = PointOfFirstID;
                    break;

            }
            idsCounter += 1;

            return point;
        } // I hate this f(), need many changes and improvement 


        private int whiteSpaceX = 2; // space X
        public int SGwhiteSpaceX //Set Get
        {
            get { return whiteSpaceX; }
            set { whiteSpaceX = value; }
        }
        private int whiteSpaceY = 2; // space Y
        public int SGwhiteSpaceY //Set Get
        {
            get { return whiteSpaceY; }
            set { whiteSpaceY = value; }
        }
        private int maxIdOnPage = 10; // at  this moment max is '10'
        public int SGmaxIdOnPage //Set Get
        {
            get { return maxIdOnPage; }
            set { if (value >= 12) { maxIdOnPage = value; } else { maxIdOnPage = 10;} }

        }

        #endregion

        public Bitmap GenA4()
        {
            float mmpi = 25.4f;
            int dpi = 150;
            Bitmap A4 = new Bitmap((int)(210 / mmpi * dpi), (int)(297 / mmpi * dpi));
            A4.SetResolution(dpi, dpi);
            return A4;
        } // Generate and return A4 Bitmap

        public int ConvertmmToA4px(float mm)
        {
            return (int)(mm / 25.4f * 150);
        }
        public float ConvertA4pxtomm(int px)
        {
            return px / 150 * 25.4f;
        }


        public Bitmap GenID(Image img, string name = "Imię", string secondName = "Nazwisko", string _class = "12")
        {
            try
            {
                Bitmap image = (Bitmap)img;

                Bitmap resized = new Bitmap(image, dimS);
                using (Graphics g = Graphics.FromImage(resized))
                {
                    //g.MeasureString(name, fontName);
                    //float WidthScaleRatio = Room.Width / RealSize.Width; 
                    g.DrawString(name, fontName, Brushes.Black, pointName);
                    g.DrawString(secondName, fontSecondName, Brushes.Black, pointSecondName);
                    g.DrawString(_class, fontClas, Brushes.Black, pointClass);
                }
                return resized;
            }
            catch
            {
                return (Bitmap)img;
            }
        } // Generate and return ID image with personals 


        string zero = "0";
        public void LinkIDonA4(Bitmap bitmap_Id)
        {
            using (Bitmap bitmapId = new Bitmap(bitmap_Id, dimS))
            {
                Bitmap a4;
                if (temp_A4IDint == 0)
                {
                    a4 = GenA4();
                }
                else
                {
                    a4 = temp_A4ID;
                }

                using (Graphics g = Graphics.FromImage(a4))
                {
                    Point point = nextPoint();
                    g.DrawImage(bitmapId, point.X,point.Y,dimS.Width,dimS.Height);
                
                }
                temp_A4IDint += 1;
                temp_A4ID = a4;

                
                if (a4counter == 10)
                {
                    zero = "";
                }



                if (temp_A4IDint == 10) 
                {
                    temp_A4ID.Save(@"C:\PamilProgramFiles\IDgen\Data\" +zero + a4counter.ToString() + ".jpeg"); // TODO tutaj trzeba z resursków wrzucić stringa
                    temp_A4IDint = 0;
                    a4counter += 1;

                    GC.Collect();// prepare 
                    GC.WaitForPendingFinalizers();//clear RAM
                    
                }
            }

            } //Link images in pattern on A4size image, and save it if count of images go up to 8.
            public void ClearFiles()
        {
            try { Directory.Delete(@"C:\PamilProgramFiles\IDgen\Data\", true);
                Directory.CreateDirectory(@"C:\PamilProgramFiles\IDgen\Data\");
            }

            catch { };
        }
    }
}
