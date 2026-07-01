using System;
using System.Web.UI;

namespace AppAWeb
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nếu AppB có gửi feedback trả về, AppA sẽ bắt lấy và hiển thị ở đây
            if (!IsPostBack)
            {
                string feedback = Request.QueryString["feedback"];
                if (!string.IsNullOrEmpty(feedback))
                {
                    lblResult.Text = "Phản hồi từ AppB: " + feedback;
                    lblResult.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

        // Bỏ chữ 'async' đi vì chúng ta không dùng HttpClient nữa
        protected void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string price = txtPrice.Text.Trim();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                lblResult.Text = "Vui lòng nhập đầy đủ thông tin!";
                lblResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Lệnh này sẽ chuyển hẳn tab trình duyệt của bạn sang trang AppB
            string url = $"http://localhost:81/AppBWeb/Default.aspx?name={Uri.EscapeDataString(name)}&price={Uri.EscapeDataString(price)}";
            Response.Redirect(url);
        }
    }
}