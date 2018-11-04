using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace L_4_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SUM.Text = "";
            Discount.Text = "";
            int countTexas = int.Parse(pizzaTexasCount.Text);
            int countCheese = int.Parse(pizzaCheeseCount.Text);
            int countKarbonara = int.Parse(pizzaKarbonaraCount.Text);
            int countBarbecue = int.Parse(pizzaBarbecueCount.Text);

            int TexasPrice1 = int.Parse(pizzaTexasPrice1.Text);
            int CheesePrice1 = int.Parse(pizzaCheesePrice1.Text);
            int KarbonaraPrice1 = int.Parse(pizzaKarbonaraPrice1.Text);
            int BarbecuePrice1 = int.Parse(pizzaBarbecuePrice1.Text);

            if (pizzaTexas.Checked)
            {
                pizzaTexasPrice.Text = (countTexas * TexasPrice1).ToString();
            }
            else { pizzaTexasPrice.Text = (0 * TexasPrice1).ToString(); }

            if (pizzaCheese.Checked)
            {
                pizzaCheesePrice.Text = (countCheese * CheesePrice1).ToString();
            }
            else { pizzaCheesePrice.Text = (0 * CheesePrice1).ToString(); }

            if (pizzaKarbonara.Checked)
            {
                pizzaKarbonaraPrice.Text = (countKarbonara * KarbonaraPrice1).ToString();
            }
            else { pizzaKarbonaraPrice.Text = (0 * KarbonaraPrice1).ToString(); }

            if (pizzaBarbecue.Checked)
            {
               pizzaBarbecuePrice.Text = (countBarbecue * BarbecuePrice1).ToString();
            }
            else { pizzaBarbecuePrice.Text = (0 * BarbecuePrice1).ToString(); }

            int Texas = int.Parse(pizzaTexasPrice.Text);
            int Cheese = int.Parse(pizzaCheesePrice.Text);
            int Karbonara = int.Parse(pizzaKarbonaraPrice.Text);
            int Barbecue = int.Parse(pizzaBarbecuePrice.Text);

            int PRICE = Texas + Cheese + Karbonara + Barbecue;


            if ((countTexas + countCheese + countKarbonara + countBarbecue) > 20)
            {
                PRICE = ((Texas + Cheese + Karbonara + Barbecue) * 90) / 100;
                Discount.Text = "знижка 10% від більше ніж 20 замовлень";
            }

            SUM.Text += PRICE.ToString() + " грн";

        }
    }
}