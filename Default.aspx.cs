using System;
using System.Web.UI;

namespace AppBWeb
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string name = Request.QueryString["name"];
                string price = Request.QueryString["price"];
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(price))
                {
                    lblInfo.Text = "Dữ liệu nhận được từ AppA:";
                    lblReceived.Text = $"Sản phẩm: <b>{name}</b> - Giá: <b>{price}</b>";
                }
            }
        }

        protected void btnSendBack_Click(object sender, EventArgs e)
        {
            string feedback = txtFeedback.Text.Trim();

            // Gói phản hồi lại và đẩy trình duyệt quay trở về AppA
            string url = $"http://localhost:81/AppAWeb/Default.aspx?feedback={Uri.EscapeDataString(feedback)}";
            Response.Redirect(url);
        }
    }
}