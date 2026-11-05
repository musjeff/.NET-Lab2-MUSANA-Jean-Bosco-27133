using System;
using System.Windows.Forms;

namespace BicycleMushroomApp;

public partial class LoginForm : Form
{
    private bool closeButtonClicked;

    public LoginForm()
    {
        InitializeComponent();
        Theme.Apply(this);

        // Block Alt+F4 and any other way of closing: only the Close button may exit.
        FormClosing += (s, e) =>
        {
            if (!closeButtonClicked && e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        };
    }

    private void btnSignIn_Click(object sender, EventArgs e)
    {
        bool userOk = !string.IsNullOrWhiteSpace(txtUsername.Text);
        bool passOk = !string.IsNullOrWhiteSpace(txtPassword.Text);

        if (!userOk || !passOk)
        {
            lblMessage.Text = !userOk && !passOk ? "Username and password are required."
                            : !userOk ? "Username cannot be empty or whitespace."
                            : "Password cannot be empty or whitespace.";
            (!userOk ? txtUsername : txtPassword).Focus();
            return;
        }

        lblMessage.Text = "";
        txtUsername.Clear();
        txtPassword.Clear();

        var menu = new MenuForm(this);
        Hide();
        menu.Show();
    }

    // The only button in the whole app that exits it.
    private void btnClose_Click(object sender, EventArgs e)
    {
        closeButtonClicked = true;
        Application.Exit();
    }
}
