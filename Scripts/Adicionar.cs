using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GerenciarSenhas
{

	public class adicionar
	{
		public static void add(Control local, Control login, Control senha)
		{
			

			using (FileStream arquivo = new FileStream("data.pas", FileMode.Append))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(arquivo))
				{

					using (FileStream arquivo1 = new FileStream("data.loc", FileMode.Append))
					{
						using (BinaryWriter binaryWriter1 = new BinaryWriter(arquivo1))
						{
							using (FileStream arquivo2 = new FileStream("data.lgn", FileMode.Append))
							{
								using (BinaryWriter binaryWriter2 = new BinaryWriter(arquivo2))
								{
									binaryWriter1.Write(local.Text);
									binaryWriter.Write(login.Text);
									binaryWriter2.Write(senha.Text);
								}
							}
						}
					}
				} 
			}

		}

		public static void procL(ListBox lista)
        { 
				using (FileStream arquivo1 = new FileStream("data.loc", FileMode.OpenOrCreate))
				{
						using (BinaryReader binaryWriter1 = new BinaryReader(arquivo1))
						{
							/*string dadoLocal;
							dadoLocal = binaryWriter1.ReadString();
							lista.Items.Add(dadoLocal);*/
						}
				}	
		}

		public static void proc(int i, Control login, Control senha)
		{
			using (FileStream arquivo1 = new FileStream("data.pas", FileMode.Open))
			{
				using (BinaryReader binaryWriter1 = new BinaryReader(arquivo1))
				{
					using (FileStream arquivo = new FileStream("data.lgn", FileMode.Open))
					{
						using (BinaryReader binaryWriter = new BinaryReader(arquivo))
						{
							if (i == 0)
							{
								login.Text = binaryWriter.ReadString();
								senha.Text = binaryWriter1.ReadString();
							}
							else
							{
								int x = 0;
								do
								{
									binaryWriter1.ReadString();
									binaryWriter.ReadString();
									x++;
								} while (x < i);

								login.Text = binaryWriter.ReadString();
								senha.Text = binaryWriter1.ReadString();
							}
						}
					}
				}

			}
		}
	}
}
