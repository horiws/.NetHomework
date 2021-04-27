using Homework5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    //0422 不能加进第二个cargo 已解决
    //0423 序号显示不出来 已解决
    //0427 删除选定货物时 自动编号栏HeaderCell.Value为null报异常
    public partial class Form2 : Form
    {
        private Order order;
        private Form1 form1;

        public Form2(Form1 form1, Order newOrder)
        {
            InitializeComponent();

            //绑定最新订单的List<Cargo>
            //cargoBindingSource.DataSource = Form1.orderService.Orders.Last()._OrderDetails._Cargo;
            this.order = newOrder;
            this.form1 = form1;

            dgv_cargo.DataSource = cargoBindingSource;
            tb_client.DataBindings.Add("Text", order._Client,"Name");//报异常：Name值不能为null
        }

        //添加货物
        private void btn_addCargo_Click(object sender, EventArgs e)
        {
            Cargo newCargo = new Cargo(
                tb_cargo.Text, int.Parse(tb_quantity.Text), double.Parse(tb_price.Text));
            this.order._OrderDetails._Cargo.Add(newCargo);

            cargoBindingSource.DataSource = this.order._OrderDetails._Cargo;

            //动态生成货物序号
            //dgv_cargo.Rows[order._OrderDetails._Cargo.Count -1].Cells[0].Value = order._OrderDetails._Cargo.Count;

            cargoBindingSource.ResetBindings(false);
            
        }
        /*
        //删除选中货物
        private void btn_deleteCargo_Click(object sender, EventArgs e)
        {
            //报异常 Value值为null
            //MessageBox.Show(dgv_cargo.SelectedRows[0].HeaderCell.Value.ToString());
            int deletedNumber = int.Parse(dgv_cargo.SelectedRows[0].HeaderCell.Value.ToString());

            string deletedCargo = dgv_cargo.SelectedCells[0].Value.ToString();

            MessageBox.Show($"确定要删除{deletedCargo}吗？");
            MessageBox.Show($"{deletedCargo}已被删除。");

            this.order._OrderDetails._Cargo.RemoveAt(deletedNumber - 1);
            //this.order._OrderDetails._Cargo.Remove

            cargoBindingSource.ResetBindings(false);
        }
        */

        //添加订单
        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            order._Client.Name = tb_client.Text;
            form1.GetOrderService.AddOrder(this.order);
            form1.orderBindingSource.ResetBindings(false);

            MessageBox.Show("订单添加成功！");

            this.Close();
        }

        //自动编号
        private void dgv_cargo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
               e.RowBounds.Location.Y,
               dgv_cargo.RowHeadersWidth - 4,
               e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics,
                  (e.RowIndex + 1).ToString(),
                   dgv_cargo.RowHeadersDefaultCellStyle.Font,
                   rectangle,
                   dgv_cargo.RowHeadersDefaultCellStyle.ForeColor,
                   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}
