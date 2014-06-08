using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkers_online
{
    class Class : System.Windows.Forms.Control
    {
        #region INIT
        // --- BEGIN CHECKERS ---
        // объявляем двумерный массив PictureBox
        private PictureBox[,] checkersBoxs = new PictureBox[4, 8];  // шашки
        private PictureBox[,] cageBoxs = new PictureBox[4, 8];      // клетки
        //
        private Bitmap blackBitmap = checkers_online.Properties.Resources.black;
        private Bitmap whiteBitmap = checkers_online.Properties.Resources.white;
        //
        public bool move = false;   // происходит ли в данный момент ход игрока
        public bool turn = true;    // чей ход сейчас: true - белые, false - чёрные
        public string tag;          // строка хода для передачи данных, при получении обрабатывается парсером

        // смещение относительно предыдущей клетки при отрисовке, значение не менять
        public int right = 0,
                   down = 0;

        // смещение игрового поля относительно начала координат
        public int _right = 51,
                   _down = 51;

        // размеры одного поля с шашкой
        public int height = 50,
                   width = 50;

        // координаты предыдущего клика
        public int i_ = 0, j_ = 0;
        // --- END CHECKERS ---

        // --- BEGIN NETWORK ---
        // инициализация сетевых реквизитов
        private const int portNum = 49015;
        public static string hostName = "localhost";
        //
        static TcpListener nListener;
        static TcpClient nClient;
        static NetworkStream nStream;
        public static Thread nThread = null;
        public static bool it_server = false;   // программа работает как сервер
        public static bool it_client = false;   // программа работает как клиент
        // --- END NETWORK ---
        #endregion


        #region BOARD
        //////public void initServerBoard(Form objForm)   {   // Инициализирует клетки доски для игры за черные шашки
        //////    down = 0;
        //////    down += _down;
        //////    for (int j = 0; j < 8; j++)     {
        //////        right += _right;
        //////        for (int i = 0; i < 4; i++)         {
        //////            if (i == 0 && j % 2 == 0) right += 50;
        //////            cageBoxs[i, j] = new PictureBox();
        //////            cageBoxs[i, j].BackColor = Color.Transparent;
        //////            cageBoxs[i, j].Location = new Point(right, down);
        //////            //cageBoxs[i, j].Name = "empty";
        //////            cageBoxs[i, j].BorderStyle = BorderStyle.FixedSingle;
        //////            cageBoxs[i, j].Tag = i.ToString() + ";" + j.ToString();
        //////            cageBoxs[i, j].Size = new Size(50, 50);
        //////            cageBoxs[i, j].TabIndex = 0;
        //////            cageBoxs[i, j].TabStop = false;
        //////            cageBoxs[i, j].Parent = objForm;
        //////            cageBoxs[i, j].BringToFront();
        //////            right += 100;
        //////        }
        //////        down += 50;
        //////        right = 0;
        //////    }
        //////}

        //////public void initClientBoard(Form objForm)   {     // Инициализирует клетки доски для игры за белые шашки
        //////    down = 0;
        //////    down += _down;
        //////    for (int j = 7; j >= 0; j--)    {
        //////        right += _right;
        //////        for (int i = 3; i >= 0; i--)        {
        //////            if (i == 3 && j % 2 != 0) right += 50;
        //////            cageBoxs[i, j] = new PictureBox();
        //////            cageBoxs[i, j].BackColor = Color.Transparent;
        //////            cageBoxs[i, j].Location = new Point(right, down);
        //////            //cageBoxs[i, j].Name = "empty";
        //////            cageBoxs[i, j].BorderStyle = BorderStyle.FixedSingle;
        //////            cageBoxs[i, j].Tag = i.ToString() + ";" + j.ToString();
        //////            cageBoxs[i, j].Size = new Size(50, 50);
        //////            cageBoxs[i, j].TabIndex = 0;
        //////            cageBoxs[i, j].TabStop = false;
        //////            cageBoxs[i, j].Parent = objForm;
        //////            cageBoxs[i, j].BringToFront();
        //////            right += 100;
        //////        }
        //////        down += 50;
        //////        right = 0;
        //////    }
        //////}

        //////public void deleteBoard()
        //////{
        //////    for (int j = 0; j < 8; j++)
        //////    {
        //////        for (int i = 0; i < 4; i++)
        //////        {
        //////            if (cageBoxs[i, j] != null) cageBoxs[i, j].Dispose();
        //////        }
        //////    }
        //////}

        #endregion


        #region CHECKERS

        public void initBlackGoFirst(Form objForm)  { // инициализирует массив шашек для игры за чёрные
            down = 0;
            down += _down;
            for (int j = 0; j < 8; j++)     {
                right += _right;
                for (int i = 0; i < 4; i++)         {
                    if (i == 0 && j % 2 == 0) right += 50;
                    checkersBoxs[i, j] = new PictureBox();
                    checkersBoxs[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    //checkersBoxs[i, j].BackColor = Color.Transparent;
                    checkersBoxs[i, j].BorderStyle = BorderStyle.FixedSingle;
                    checkersBoxs[i, j].Location = new Point(right, down);
                    checkersBoxs[i, j].Name = "empty";
                    checkersBoxs[i, j].Tag = i.ToString() + ";" + j.ToString();
                    checkersBoxs[i, j].Size = new Size(width, height);
                    checkersBoxs[i, j].TabIndex = 0;
                    checkersBoxs[i, j].TabStop = false;
                    checkersBoxs[i, j].Parent = objForm;
                    checkersBoxs[i, j].Click += new EventHandler(pictureBox_Click);
                    checkersBoxs[i, j].BringToFront();
                    right += 100;
                }
                down += 50;
                right = 0;
            }
        }

        public void initWhiteGoFirst(Form objForm)  { // инициализирует массив шашек для игры за белые
            down = 0;
            down += _down;
            for (int j = 7; j >= 0; j--)    {
                right += _right;
                for (int i = 3; i >= 0; i--)        {
                    if (i == 3 && j % 2 != 0) right += 50;
                    checkersBoxs[i, j] = new PictureBox();
                    checkersBoxs[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    //checkersBoxs[i, j].BackColor = Color.Transparent;
                    checkersBoxs[i, j].BorderStyle = BorderStyle.FixedSingle;
                    checkersBoxs[i, j].Location = new Point(right, down);
                    checkersBoxs[i, j].Name = "empty";
                    checkersBoxs[i, j].Tag = i.ToString() + ";" + j.ToString();
                    checkersBoxs[i, j].Size = new Size(width, height);
                    checkersBoxs[i, j].TabIndex = 0;
                    checkersBoxs[i, j].TabStop = false;
                    checkersBoxs[i, j].Parent = objForm;
                    checkersBoxs[i, j].Click += new EventHandler(pictureBox_Click);
                    checkersBoxs[i, j].BringToFront();
                    right += 100;
                }
                down += 50;
                right = 0;
            }
        }

        public void initCheckersWhite()  // заполняет массив клеток белыми шашками
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    checkersBoxs[i, j].Image = whiteBitmap;
                    checkersBoxs[i, j].Name = "white";
                }
            }
        }

        public void initCheckersBlack()  // заполняет массив клеток чёрными шашками
        {
            for (int j = 5; j < 8; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    checkersBoxs[i, j].Image = blackBitmap;
                    checkersBoxs[i, j].Name = "black";
                }
            }
        }

        public void deleteCheckers()
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (checkersBoxs[i, j] != null) checkersBoxs[i, j].Dispose();
                }
            }
        }
        #endregion


        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (move == false)
            {
                move = true;
                tag = (string) ((PictureBox) sender).Tag;
                string[] temp_mas = (tag.Split(';'));
                int i = int.Parse(temp_mas[0]);
                int j = int.Parse(temp_mas[1]);
                ////////check(i, j);
            }
            else
            {
                move = false;
                tag = tag + ";" + (string) ((PictureBox) sender).Tag;
                _move(tag);
                write(tag);
                tag = null;
            }
        }

        public void _move(string tag)
        {
            string[] temp_mas = (tag.Split(';'));
            int i = int.Parse(temp_mas[0]);
            int j = int.Parse(temp_mas[1]);
            int i_ = int.Parse(temp_mas[2]);
            int j_ = int.Parse(temp_mas[3]);
            if (check(i, j, i_, j_) == "true")
            {
                checkersBoxs[i_, j_].Image = checkersBoxs[i, j].Image;
                checkersBoxs[i, j].Image = null;
            }

        }

        public string check(int i, int j, int i_, int j_)
        {

            //if (j % 2 != 0)
            //{
            //    checkersBoxs[i, (j - 1)];
            //    if ((i - 1) >= 0) checkersBoxs[i - 1, j - 1];
            //}
            //else
            //{
            //    checkersBoxs[i, (j - 1)];
            //    if ((i + 1) < 4) checkersBoxs[i + 1, j - 1];
            //}


            ////if (j % 2 != 0)
            ////{
            ////    i, (j - 1)
            ////    if ((i - 1) >= 0) (i - 1), (j - 1)
            ////}
            ////else
            ////{
            ////    i, (j - 1)
            ////    if ((i + 1) < 4) (i + 1), (j - 1)
            ////}


            string temp=null;
            if (((j - j_) == 1) || ((j - j_) == -1))
            {
                if (j%2 != 0)
                {
                    if ((i == i_ && (j - 1) == j_) || (((i - 1) >= 0) && (i - 1) == i_ && (j - 1) == j_))
                    {
                        temp = "true";
                    }

                }
                else
                {
                    if ((i == i_ && (j - 1) == j_) || (((i + 1) < 4) && (i + 1) == i_ && (j - 1) == j_))
                    {
                        temp = "true";
                    }
                }
            }
            else
            {
                attack(i, j, i_, j_);
            }



            return temp;




            //{
            //    string name = checkersBoxs[i, j].Name;
            //    if (name == "black")
            //    {
            //        //move = true;
            //        if (j % 2 != 0)
            //        {
            //            checkersBoxs[i, (j - 1)].BorderStyle = BorderStyle.FixedSingle;
            //            if ((i - 1) >= 0) checkersBoxs[i - 1, j - 1].BorderStyle = BorderStyle.Fixed3D;
            //        }
            //        else
            //        {
            //            checkersBoxs[i, (j - 1)].BorderStyle = BorderStyle.Fixed3D;
            //            if ((i + 1) < 4) checkersBoxs[i + 1, j - 1].BorderStyle = BorderStyle.Fixed3D;
            //        }
            //    }
            //    if (name == "white")
            //    {
            //        //move = true;
            //        if (j % 2 != 0)
            //        {
            //            cageBoxs[i, (j + 1)].BorderStyle = BorderStyle.Fixed3D;
            //            if ((i - 1) >= 0) cageBoxs[i - 1, j + 1].BorderStyle = BorderStyle.Fixed3D;
            //        }
            //        else
            //        {
            //            cageBoxs[i, (j + 1)].BorderStyle = BorderStyle.Fixed3D;
            //            if ((i + 1) < 4) cageBoxs[i + 1, j + 1].BorderStyle = BorderStyle.Fixed3D;
            //        }
            //    }
            //}
        }

        public string attack(int i, int j, int i_, int j_)
        {
            string temp = null;
            // обрабатываем рубку
            MessageBox.Show("attack", "", MessageBoxButtons.OK);
            return temp;
        }


        #region NETWORK

        public void set_hostName(string ip)     {
            hostName = ip;
        }

        public void nServer_start()     {
            it_server = true;
            nListener = new TcpListener(new IPEndPoint(IPAddress.Any, portNum));
            nListener.Start();
            nClient = nListener.AcceptTcpClient();
            nStream = nClient.GetStream();
            nThread = new Thread(NetWorkProcessor);
            nThread.Start();
        }
        public void nServer_stop()      {

            if (it_server) nListener.Stop();
            if (it_client) nClient.Close();
            if (nThread != null) nThread.Abort();
            it_server = false;
            deleteCheckers();
        }
        public void nClient_start()
        {
            try
            {
                nClient = new TcpClient(hostName, portNum);
                nStream = nClient.GetStream();
                //String s = "Connected";
                //byte[] byteTime = Encoding.ASCII.GetBytes(s);
                //nStream.Write(byteTime, 0, byteTime.Length);
                nThread = new Thread(NetWorkProcessor);
                nThread.Start();
                it_client = true;
            }
            catch (SocketException e)   // исключение, возникающее при попытке коннекта к несуществующему серверу
            {
                var s = MessageBox.Show("ошибка", "", MessageBoxButtons.OK);
                if (s == DialogResult.OK)
                {
                    nServer_stop();
                    nClient_stop();
                }
            }


        }
        public void nClient_stop()
        {
            if (it_server) nListener.Stop();
            if (it_client) nClient.Close();
            if (nThread != null) nThread.Abort();
            it_client = false;
            deleteCheckers();
        }
        public void write(string tag)
        {
            if (tag != null)
            {
                byte[] byteTime = Encoding.ASCII.GetBytes(tag);
                //nStream.Write(byteTime, 0, byteTime.Length);      //раскомментить при отладке сетевого взаимодействия!!!
            }
        }

        public void NetWorkProcessor()
        {
            byte[] bytes = new byte[1024];
            while (true)
            {
                int bytesRead = nStream.Read(bytes, 0, bytes.Length);
                //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                _move(Encoding.ASCII.GetString(bytes, 0, bytesRead));
            }
        }


        


        public void closeThread()
        {
            nClient_stop();
            nServer_stop();
        }


#endregion


    }
}
