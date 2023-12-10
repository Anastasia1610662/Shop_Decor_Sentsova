using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Decor_Sentsova
{
    public partial class fTicket : Form
    {
        List<Order> showOrders;

        public fTicket(List<Order> order)
        {
            InitializeComponent();
            showOrders = order;
            lstTicket.DataSource = showOrders;
            decimal finalSumWithDiscount = 0;
            int finalSumDiscountAmount = 0;
            foreach (Order ord in showOrders)
            {
                finalSumWithDiscount += Convert.ToDecimal(ord.ProductCostWithDiscount);
                finalSumDiscountAmount += Convert.ToInt32(ord.ProductDiscountAmount);
            }
            lblCostWithDiscount.Text = $"Сумма заказа: {finalSumWithDiscount}";
            lblCostDiscounts.Text = $"Сумма скидки: {finalSumDiscountAmount}%";
            lblPickUpPoint.Text = $"Пункт выдачи: {Order.OrderPickUpPoint}";
            lblOrderDate.Text = $"Дата заказа: {Order.OrderDate.ToString("D")}";
            lblOrderCode.Text = $"Код заказа\n {Order.OrderCode}";
        }
    }
}
