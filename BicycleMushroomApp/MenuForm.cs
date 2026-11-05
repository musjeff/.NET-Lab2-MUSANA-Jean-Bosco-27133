using System;
using System.Windows.Forms;

namespace BicycleMushroomApp;

public partial class MenuForm : Form
{
    private readonly LoginForm login;

    // Needed so the Designer can load the form.
    public MenuForm() : this(null) { }

    public MenuForm(LoginForm login)
    {
        this.login = login;
        InitializeComponent();
        Theme.Apply(this);

        // Menu closed -> back to Login (never exits the application).
        FormClosed += (s, e) => this.login?.Show();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
        Form child = rbBicycle.Checked ? new BicycleRentalForm() : new MushroomIdentifierForm();
        child.FormClosed += (s, args) => Show();   // child closed -> back to Menu
        Hide();
        child.Show();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();   // closes Menu only, which returns to Login
    }
}
