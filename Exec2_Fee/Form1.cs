using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Fee
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Exec2_Fee
		/// 根據客戶性別及年齡計算應付車資，規則如下:
		/// 年紀≤ 3：0元；年紀≥70，男生：2元；≥60，女性：3元；全票15元
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = string.Empty;
			genderCbBox.SelectedIndex = 0;
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			//取得性別和年紀
			string gender = GetGender(); ;
			int age;

			try
			{
				age = GetAge();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//計算票價
			int charge = CalcFee(gender, age);

			//呈現
			resultLabel.Text = $"本次搭乘票價為{charge} 元。";
		}

		private int CalcFee(string gender, int age)
		{
			if (gender == "男性" && age >= 70)
			{
				return 3;
			}

			if (gender == "女性" && age >= 60)
			{
				return 2;
			}

			if (age <= 3)
			{
				return 0;
			}

			return 15;
		}

		private int GetAge()
		{
			string input = Convert.ToString(ageTextBox.Text);
			bool isInt = int.TryParse(input, out int age);

			if (string.IsNullOrEmpty(input))
			{
				throw new Exception("請輸入數字。");
			}

			if (isInt == false)
			{
				throw new Exception("僅可以填入數字。");
			}

			if (age < 0)
			{
				throw new Exception("年紀不可小於零。");
			}

			return age;
		}

		private string GetGender()
		{
			ComboBox item = this.genderCbBox;
			object selectedItem = item.SelectedItem;

			return selectedItem != null ? selectedItem.ToString() : null;
		}
	}
}
