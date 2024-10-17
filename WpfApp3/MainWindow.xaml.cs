using System.Windows;
using System.Windows.Controls;

namespace WpfApp3;
public partial class MainWindow : Window
{
	public double number;

	public string symbol;
	private object textBox_screen;

	public MainWindow()
	{
		InitializeComponent();
	}

	private void All_Buttons(object sender, RoutedEventArgs e)
	{
		Button button = ( Button ) sender;
		if( text_box.Text != "0" )
			text_box.Text += button.Content;

		else
		{
			text_box.Text = "";
			text_box.Text += button.Content;
		}
	}

	private void clr(object sender, RoutedEventArgs e)
	{
		Result.Content = "0";
		text_box.Text = "0";
		number = 0;
	}

	private void Back(object sender, RoutedEventArgs e)
	{

		if( text_box.Text.Length != 0 )
		{
			text_box.Text = text_box.Text.Remove(text_box.Text.Length - 1, 1);
		}
		else if( text_box.Text.Length == 0 )
		{
			text_box.Text = "0";
		}
	}

	private void plus(object sender, RoutedEventArgs e)
	{
		symbol = "+";
		if( number != 0 )
		{
			double sayi;
			double.TryParse(text_box.Text, out sayi);
			text_box.Text = ( number + sayi ).ToString();

		}

		double.TryParse(text_box.Text, out number);
		Result.Content = number + symbol;
		text_box.Text = "0";

	}

	private void Minus(object sender, RoutedEventArgs e)
	{

		symbol = "-";
		if( number != 0 )
		{
			double sayi;
			double.TryParse(text_box.Text, out sayi);
			text_box.Text = ( number - sayi ).ToString();
		}
		double.TryParse(text_box.Text, out number);
		Result.Content = number + symbol;
		text_box.Text = "0";
	}

	private void Multiplication(object sender, RoutedEventArgs e)
	{
		symbol = "*";
		if( number != 0 )
		{
			double sayi;
			double.TryParse(text_box.Text, out sayi);
			text_box.Text = ( number * sayi ).ToString();
		}
		double.TryParse(text_box.Text, out number);
		Result.Content = number + symbol;
		text_box.Text = "0";
	}

	private void Divide(object sender, RoutedEventArgs e)
	{
		symbol = "/";
		bool check = false;

		if( number != 0 )
		{
			double sayi;
			double.TryParse(text_box.Text, out sayi);

			if( sayi == 0 )
				check = true;

			else
			{
				text_box.Text = ( number / sayi ).ToString();
				check = false;
			}
		}

		double.TryParse(text_box.Text, out number);

		Result.Content = number + symbol;

		if( check )
			text_box.Text = "Hata";
		else
			text_box.Text = "0";
	}

	private void Square(object sender, RoutedEventArgs e)
	{
		number = Double.Parse(text_box.Text);
		text_box.Text = ( Math.Sqrt(number) ).ToString();
	}

	private void Power(object sender, RoutedEventArgs e)
	{
		number = Double.Parse(text_box.Text);
		text_box.Text = ( number * number ).ToString();
	}

	private void together(object sender, RoutedEventArgs e)
	{
		if( symbol == "+" )
		{
			if( text_box.Text == "0" )
			{
				text_box.Text = number.ToString();
				symbol = "";
			}

			else
			{
				double num_2 = Convert.ToDouble(text_box.Text);
				text_box.Text = Convert.ToString(number + num_2);
				Result.Content = null;
				number = 0;
			}
		}


		if( symbol == "-" )
		{
			if( text_box.Text == "0" )
			{
				text_box.Text = number.ToString();
				symbol = "";
			}
			else
			{
				double num_2 = Convert.ToDouble(text_box.Text);
				text_box.Text = Convert.ToString(number - num_2);
				Result.Content = null;
				number = 0;
			}
		}


		if( symbol == "*" )
		{
			if( text_box.Text == "0" )
			{
				text_box.Text = number.ToString();
				symbol = "";
			}
			else
			{
				double num_2 = Convert.ToDouble(text_box.Text);
				text_box.Text = Convert.ToString(number * num_2);
				Result.Content = null;
				number = 0;
			}
		}



		if( symbol == "/" )
		{
			if( text_box.Text == "0" )
			{
				text_box.Text = number.ToString();
				symbol = "";
			}
			else
			{
				double num_2 = Convert.ToDouble(text_box.Text);
				if( num_2 != 0 )
				{
					text_box.Text = Convert.ToString(number / num_2);
					Result.Content = null;
					number = 0;
				}

				else
					text_box.Text = "Hata";
			}

		}
		Result.Content = "0";
		number = 0;
	}


}