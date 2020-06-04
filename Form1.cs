using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace Symmetr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VernCode_Click(object sender, EventArgs e)// кодирование Вернамом
        {
            string MainText = @"C:\Code\VernText.txt";
            string KeyText = @"C:\Code\VernKey.txt";
            string[] Main = File.ReadAllLines(MainText);// получение строки из файла с начальным сообщением
            string[] Key = File.ReadAllLines(KeyText);// Получение ключа
            byte[] ConvTo = new byte[1];// временная переменная для конвертированного символа
            byte[] MainByte = Encoding.UTF8.GetBytes(Main[0]);// массив байтов из сообщения
            byte[] KeyByte = Encoding.UTF8.GetBytes(Key[0]);// массив байтов из ключа
            string TextToCode = Main[0];
            for (int i = 0; i < TextToCode.Length; i++)// пока не закончится текст в строке TextToCode
            {
                int a = Convert.ToInt16(MainByte[i]) ^ Convert.ToInt16(KeyByte[i]);// операция XOR
                ConvTo[0] = Convert.ToByte(a);// конвертирование а в байт
                string MesToFile = Encoding.UTF8.GetString(ConvTo);// перевод в текстовый вид из байта
                using (StreamWriter FCode = new StreamWriter(@"C:\Code\VernCode.txt", true, System.Text.Encoding.UTF8))// запись в файл с кодированным сообщением
                {
                    FCode.Write(MesToFile);
                }
            }
        }

        private void VernDecode_Click(object sender, EventArgs e)// декодирование Вернамом
        {
            string KeyText = @"C:\Code\VernKey.txt";
            string CodeText = @"C:\Code\VernCode.txt";
            string[] Main = File.ReadAllLines(CodeText);// получение строки из файла с кодированным сообщением
            string[] Key = File.ReadAllLines(KeyText);
            byte[] ConvTo = new byte[1];
            byte[] MainByte = Encoding.UTF8.GetBytes(Main[0]);
            byte[] KeyByte = Encoding.UTF8.GetBytes(Key[0]);
            string TextToCode = Main[0];
            for (int i = 0; i < TextToCode.Length; i++)
            {
                int a = Convert.ToInt16(MainByte[i]) ^ Convert.ToInt16(KeyByte[i]);
                ConvTo[0] = Convert.ToByte(a);
                string MesToFile = Encoding.UTF8.GetString(ConvTo);
                using (StreamWriter FCode = new StreamWriter(@"C:\Code\VernDecode.txt", true, System.Text.Encoding.UTF8))
                {
                    FCode.Write(MesToFile);
                }
            }
        }

        private void RC2Code_Click(object sender, EventArgs e)// кодирование с помощью библиотеки RC2
        {
            string MainText = MainTextBox.Text;// получение текста из текстового окна
            string KeyText = KeyTextBox.Text;// получение ключа из текстового окна
            RC2 RC2alg = RC2.Create();// создание экземпляра RС2
            byte[] toEncrypt = new UTF8Encoding().GetBytes(MainText);
            byte[] KeyByte = new UTF8Encoding().GetBytes(KeyText);
            byte[] IV = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            MemoryStream mStream = new MemoryStream();// поток с памятью в качестве резервного хранилища
            CryptoStream CodeRC2 = new CryptoStream(mStream, RC2alg.CreateEncryptor(KeyByte, IV), CryptoStreamMode.Write);// поток кодирующий информацию с заданным ключем и вектором
            CodeRC2.Write(toEncrypt, 0, toEncrypt.Length);// будут закодированы все элементы
            CodeRC2.FlushFinalBlock();// обновление данных и очистка буфера
            byte[] ret = mStream.ToArray();
            string EncryptMes = Convert.ToBase64String(ret);
            CodeTextBox.Text = EncryptMes;
            CodeRC2.Close();// закрытие кодирующего потока
            mStream.Close();// закрытие потока с памятью
        }

        private void RC2Decode_Click(object sender, EventArgs e)// декодирование с помощью библиотеки RC2
        {
            string KeyText = KeyTextBox.Text;
            string CodeText = CodeTextBox.Text;
            RC2 RC2alg = RC2.Create();
            byte[] KeyByte = new UTF8Encoding().GetBytes(KeyText);
            byte[] toDecrypt = Convert.FromBase64String(CodeText);
            byte[] IV = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            MemoryStream DecodeStream = new MemoryStream();
            CryptoStream DecodeRC2 = new CryptoStream(DecodeStream, RC2alg.CreateDecryptor(KeyByte, IV), CryptoStreamMode.Write);//поток, декодирующий информацию с заданным ключем и вектором
            DecodeRC2.Write(toDecrypt, 0, toDecrypt.Length);
            DecodeRC2.FlushFinalBlock();
            byte[] ret = DecodeStream.ToArray();
            string DecryptMes = new UTF8Encoding().GetString(ret);
            DecodeTextBox.Text = DecryptMes;
            DecodeRC2.Close();
            DecodeStream.Close();
        }
    }
}
