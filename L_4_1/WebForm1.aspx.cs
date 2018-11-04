using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace L_4_1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Discount.Text = "";
            SUM.Text = "";
            int countTexas = int.Parse(pizzaTexasCount.Text);
            int countCheese = int.Parse(pizzaCheeseCount.Text);
            int countKarbonara = int.Parse(pizzaKarbonaraCount.Text);
            int countBarbecue = int.Parse(pizzaBarbecueCount.Text);

            int TexasPrice1 = int.Parse(pizzaTexasPrice1.Text);
            int CheesePrice1 = int.Parse(pizzaCheesePrice1.Text);
            int KarbonaraPrice1 = int.Parse(pizzaKarbonaraPrice1.Text);
            int BarbecuePrice1 = int.Parse(pizzaBarbecuePrice1.Text);

            pizzaTexasPrice.Text = (countTexas * TexasPrice1).ToString();
            pizzaCheesePrice.Text = (countCheese * CheesePrice1).ToString();
            pizzaKarbonaraPrice.Text = (countKarbonara * KarbonaraPrice1).ToString();
            pizzaBarbecuePrice.Text = (countBarbecue * BarbecuePrice1).ToString();

            int Texas = int.Parse(pizzaTexasPrice.Text);
            int Cheese = int.Parse(pizzaCheesePrice.Text);
            int Karbonara = int.Parse(pizzaKarbonaraPrice.Text);
            int Barbecue = int.Parse(pizzaBarbecuePrice.Text);

            int PRICE = 0;


            if (RadioButtonList1.SelectedItem != null)
            {
                PRICE = Texas;
                IsDiscount(countTexas);
                SUM.Text += PRICE.ToString() + " грн";
            }

            if (RadioButtonList1.SelectedItem != null)
            {
                PRICE = Cheese;
                IsDiscount(countCheese);
                SUM.Text += PRICE.ToString() + " грн";
            }

            if (RadioButtonList1.SelectedItem != null)
            {
                PRICE = Karbonara;
                IsDiscount(countKarbonara);
                SUM.Text += PRICE.ToString() + " грн";
            }

            if (RadioButtonList1.SelectedItem != null)
            {
                PRICE = Barbecue;
                IsDiscount(countBarbecue);
                SUM.Text += PRICE.ToString() + " грн";
            }


            void IsDiscount(int numberOfPizzas)
            {
                if (numberOfPizzas > 20)
                {
                    PRICE = (PRICE * 90) / 100;
                    Discount.Text = "знижка 10% від більше ніж 20 замовлень";
                }
            }
        }
    }
}
