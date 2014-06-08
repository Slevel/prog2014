using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using checkers_online;

namespace checkers_online
{
    
    public partial class Main_window : Form     {
        Class checkers = new Class();
        //GameBoard board = new GameBoard();

        public Main_window()    {
            InitializeComponent();
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_window_FormClosing);
            //Thread splashThread = new Thread(new ThreadStart(SplashScreen));
            //splashThread.Start();
            //Thread.Sleep(6000);
            //splashThread.Abort();
        }

        public void SplashScreen()
        {
            Application.Run(new Splash_screen());
        }

        private void initGame_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _startGameAsServer();
        }

        private void joinGame_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _startGameAsClient();
        }

        private void main_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkers.closeThread(); // действие при закрытии формы
        }

        private void restartGame_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _stopGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //////checkers.deleteBoard();
            checkers.deleteCheckers();
            checkers.down = 0;
            Controls.Add(checkers);
            //checkers.initServerBoard(this);
            checkers.initBlackGoFirst(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //////checkers.deleteBoard();
            checkers.deleteCheckers();
            checkers.down = 0;
            Controls.Add(checkers);
            //checkers.initClientBoard(this);
            checkers.initWhiteGoFirst(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //checkers.deleteCheckers();
            checkers.initCheckersWhite();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //checkers.deleteCheckers();
            checkers.initCheckersBlack();
        }

        private void _startGameAsServer()   // начало игры в роли сервера
        {
            //////checkers.deleteBoard();
            checkers.deleteCheckers();
            //////checkers.initServerBoard(this);
            checkers.initBlackGoFirst(this);
            checkers.initCheckersWhite();
            checkers.initCheckersBlack();
            checkers.nServer_start();
            joinGame_ToolStripMenuItem.Enabled = false;
            initGame_ToolStripMenuItem.Enabled = false;
        }

        private void _startGameAsClient()   // начало игры в роли клиента
        {
            //////checkers.deleteBoard();
            checkers.deleteCheckers();
            //////checkers.initClientBoard(this);
            checkers.initWhiteGoFirst(this);
            checkers.initCheckersWhite();
            checkers.initCheckersBlack();
            checkers.nClient_start();
            initGame_ToolStripMenuItem.Enabled = false;
            joinGame_ToolStripMenuItem.Enabled = false;
        }

        private void _stopGame()
        {
            checkers.set_hostName("localhost"); // убрать это позже
            checkers.nServer_stop();
            checkers.nClient_stop();
            checkers.deleteCheckers();
            //////checkers.deleteBoard();
            initGame_ToolStripMenuItem.Enabled = true;
            joinGame_ToolStripMenuItem.Enabled = true;
        }
    }
}
