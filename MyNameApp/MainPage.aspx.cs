using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyNameApp
{
	public partial class MainPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Add_Click(object sender, EventArgs e)
		{
			Int32 result = 0;
			if(Int32.TryParse(Value1.Text, out result))
			{
				if(Int32.TryParse(Value2.Text, out Int32 val2))
				{
					result += val2;
				}
			}
			Result.Text = result.ToString();
		}

		protected void Multiply_Click(object sender, EventArgs e)
		{
			Int32 result;
			if (Int32.TryParse(Value1.Text, out result))
			{
				if (Int32.TryParse(Value2.Text, out Int32 val2))
				{
					result *= val2;
				}
			}
			Result.Text = result.ToString();
		}

		protected void Subtract_Click(object sender, EventArgs e)
		{
			Int32 result;
			if (Int32.TryParse(Value1.Text, out result))
			{
				if (Int32.TryParse(Value2.Text, out Int32 val2))
				{
					result -= val2;
				}
			}
			Result.Text = result.ToString();
		}

		protected void Divide_Click(object sender, EventArgs e)
		{
			Int32 result;
			if (Int32.TryParse(Value1.Text, out result))
			{
				if (Int32.TryParse(Value2.Text, out Int32 val2))
				{
					result /= val2;
				}
			}
			Result.Text = result.ToString();
		}
	}
}