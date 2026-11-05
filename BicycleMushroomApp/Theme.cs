using System.Drawing;
using System.Windows.Forms;

namespace BicycleMushroomApp;

// Gives every form the same clean look. Called once from each form's constructor.
internal static class Theme
{
    private static readonly Color Accent = Color.FromArgb(0, 120, 212);
    private static readonly Color CloseColor = Color.FromArgb(108, 117, 125);

    public static void Apply(Form form)
    {
        form.BackColor = Color.FromArgb(245, 247, 250);
        form.Font = new Font("Segoe UI", 9F);
        Style(form.Controls);
    }

    private static void Style(Control.ControlCollection controls)
    {
        foreach (Control c in controls)
        {
            if (c is Button b)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.ForeColor = Color.White;
                b.BackColor = b.Name == "btnClose" ? CloseColor : Accent;
                b.Cursor = Cursors.Hand;
            }
            if (c.HasChildren) Style(c.Controls);
        }
    }
}
