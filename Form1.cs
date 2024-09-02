using PatronObserver.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronObserver
{
    public partial class Form1 : Form
    {
        private Editor editor;
        private LoggingListener logListener;
        private EmailAlertsListener emailListener;
        private bool isSubscribed;

        public Form1()
        {
            InitializeComponent();
            editor = new Editor();
            logListener = new LoggingListener("log.txt", "Usuario ha iniciado sesión");
            emailListener = new EmailAlertsListener("email@example.com", "Archivo modificado");

            btnSubscribe.Enabled = false;
            btnUnsubsribe.Enabled = false;
            btnLogin.Enabled = true;
            isSubscribed = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnSubscribe.Enabled = true;
            editor.OpenFile("archivo.txt");
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (!isSubscribed)
            {
                editor.Events.Subscribe(logListener);
                editor.Events.Subscribe(emailListener);
                isSubscribed = true;
                MessageBox.Show("Suscrito a los eventos.");

                btnSubscribe.Enabled = false;
                btnUnsubsribe.Enabled = true;
            }
        }

        private void btnUnsubsribe_Click(object sender, EventArgs e)
        {
            if (isSubscribed)
            {
                editor.Events.Unsubscribe(logListener);
                editor.Events.Unsubscribe(emailListener);
                isSubscribed = false;
                MessageBox.Show("Desuscrito de los eventos.");

                btnSubscribe.Enabled = true;
                btnUnsubsribe.Enabled = false;
            }
        }
    }
}
