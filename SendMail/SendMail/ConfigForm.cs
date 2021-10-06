﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
       
        private Settings settings = Settings.getInstance();
        public ConfigForm() 
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            
            tbHost.Text = settings.sHost();
            tbPass.Text = settings.sPass();
            tbUserName.Text = settings.sMailAddr();
            tbPort.Text = settings.sPort();
            cbSsl.Checked = settings.bSsl();
            tbSender.Text = settings.sMailAddr();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            SettingRegist();
            
            //シリアル化
            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            
            using(var writer = XmlWriter.Create("mailsetting.xml",xws))
            {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }
            


            this.Close();
        }

        //送信データ登録
        private void SettingRegist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            SettingRegist();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
