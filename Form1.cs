using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework5;

namespace Homework8
{
    public partial class Form1 : Form
    {
        private OrderService orderService;
        public OrderService GetOrderService { get => orderService; }
        //private List<Order> queryOrders;//写在OrderService 保存查询到的订单

        public string Keyword;
        //public string Keyword { get; set; }
        public string[] queryItems = {"订单号","货物名","客户名" };

        public Form1()
        {
            //初始化
            InitializeComponent();

            orderService = new OrderService();
            //queryOrders = new List<Order>();

            //数据绑定
            this.textBox1.DataBindings.Add("Text", this, Keyword);
            cb_queryItems.DataSource = queryItems;

            orderBindingSource.DataSource = orderService.Orders;

            //点击任意订单 右侧显示订单明细
            this.dgv_order.CellClick += dgv_CellClick;
        }

        //添加订单
        private void btn_add_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(this, new Order());
            form2.Show();
        }

        //删除订单
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int deletedOrderID = int.Parse(dgv_order.SelectedCells[0].Value.ToString());
            this.orderService.DeleteOrder(deletedOrderID);

            MessageBox.Show($"{deletedOrderID}号订单删除成功。");

            orderBindingSource.DataSource = orderService.Orders;
            orderBindingSource.ResetBindings(false);
        }

        //按关键词查询订单
        private void btn_query_Click(object sender, EventArgs e)
        {
            //string selectedItem = cb_queryItems.SelectedItem.ToString();
            //keyword = textBox_query.Text;
            orderBindingSource.DataSource = orderService.QueryOrders;
            int selectedIndex = cb_queryItems.SelectedIndex;

            switch (selectedIndex)
            {
                //按订单号查询
                case 0:

                    orderService.QueryOrders = orderService.QueryByOrderID(int.Parse(Keyword));
                    if(orderService.QueryOrders.Count() == 0)
                    {
                        MessageBox.Show($"NO.{Keyword} orders was not found.");
                    }
                    break;
                    
                //按货物名查询
                case 1:

                    orderService.QueryOrders = orderService.QueryByCargo(Keyword);
                    if (orderService.QueryOrders.Count() == 0)
                    {
                        MessageBox.Show($"Order(s) containing {Keyword} was not found.");
                    }
                    //测试用 queryOrders数量为0
                    //textBox1.Text = orderService.QueryOrders.Count().ToString();
                    break;

                //按客户名查询
                case 2:

                    orderService.QueryOrders = orderService.QueryByClient(Keyword);
                    if (orderService.QueryOrders.Count() == 0)
                    {
                        MessageBox.Show($"Order(s) placed by {Keyword} was not found.");
                    }
                    break;
            }

            orderBindingSource.ResetBindings(false);

        }

        //点击单元格显示对应订单明细
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedOrder = int.Parse(dgv_order.Rows[e.RowIndex].Cells[0].Value.ToString());

            cargoBindingSource1.DataSource =
                orderService.Orders[selectedOrder - 1]._OrderDetails._Cargo;

            cargoBindingSource1.ResetBindings(false);
        }

        //修改订单
        private void btn_modify_Click(object sender, EventArgs e)
        {
            int newQuantity = int.Parse(dgv_detail.SelectedCells[1].Value.ToString());
            string modifiedCargo = dgv_detail.SelectedCells[0].Value.ToString();

            int modifiedID = this.orderService.QueryByCargo(modifiedCargo).First().ID;

            this.orderService.ModifyOrder(modifiedID, modifiedCargo, newQuantity);

            MessageBox.Show($"{modifiedCargo}的数量已修改为{newQuantity}。");
        }

        //导出订单
        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Xml 文件(*.xml)|*.xml|所有文件(*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.RestoreDirectory = false;
            saveFileDialog.DefaultExt = ".xml";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.orderService.Export(saveFileDialog.FileName);

                MessageBox.Show("订单已导出。");
            }
        }

        //导入订单
        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Xml 文件(*.xml)|*.xml|所有文件(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.RestoreDirectory = false;
            //openFileDialog.DefaultExt = ".xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
               // List<Order> importOrders = this.orderService.Import(fileName);

              //  orderBindingSource.DataSource = importOrders;
                orderBindingSource.ResetBindings(false);

                MessageBox.Show("订单已导入。");

            }
        }

        //刷新查看全部订单
        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = orderService.Orders;
            orderBindingSource.ResetBindings(false);
        }
    }
}