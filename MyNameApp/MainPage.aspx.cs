using System;

namespace MyNameApp
{
	public partial class MainPage : System.Web.UI.Page
	{
		CalcService.CalculatorSoapClient calcService = new CalcService.CalculatorSoapClient();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Add_Click(object sender, EventArgs e)
		{
			Int32 result = 0, val2;
			if(Int32.TryParse(Value1.Text, out result))
				if(Int32.TryParse(Value2.Text, out val2))
					result = calcService.Add(result, val2);
			Result.Text = result.ToString();
		}

		protected void Multiply_Click(object sender, EventArgs e)
		{
			Int32 result = 0, val2;
			if (Int32.TryParse(Value1.Text, out result))
				if (Int32.TryParse(Value2.Text, out val2))
					result = calcService.Multiply(result, val2);
			Result.Text = result.ToString();
		}

		protected void Subtract_Click(object sender, EventArgs e)
		{
			Int32 result = 0, val2;
			if (Int32.TryParse(Value1.Text, out result))
				if (Int32.TryParse(Value2.Text, out val2))
					result = calcService.Subtract(result, val2);
			Result.Text = result.ToString();
		}

		protected void Divide_Click(object sender, EventArgs e)
		{
			Int32 result = 0, val2;
			if (Int32.TryParse(Value1.Text, out result))
				if (Int32.TryParse(Value2.Text, out val2))
					result = calcService.Divide(result, val2);
			Result.Text = result.ToString();
		}
	}
}