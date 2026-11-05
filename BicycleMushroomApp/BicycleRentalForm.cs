using System;
using System.Drawing;
using System.Windows.Forms;

namespace BicycleMushroomApp;

public partial class BicycleRentalForm : Form
{
    public BicycleRentalForm()
    {
        InitializeComponent();
        Theme.Apply(this);
    }

    // Rate in RWF for the hour slot beginning at 'hour' (0-23).
    private static int RateForHour(int hour)
    {
        if (hour < 7 || hour >= 21) return 500;     // 0-7 and 21-24
        if (hour < 14 || hour >= 19) return 1000;   // 7-14 and 19-21
        return 1500;                                // 14-19
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
        lblResult.ForeColor = Color.Firebrick;

        // int.TryParse rejects decimals such as "7.5".
        if (!int.TryParse(txtStart.Text.Trim(), out int start) ||
            !int.TryParse(txtEnd.Text.Trim(), out int end))
        {
            lblResult.Text = "Please enter whole numbers only (no decimals).";
            return;
        }
        if (start < 0 || start > 23) { lblResult.Text = "Start time must be between 0 and 23."; return; }
        if (end < 1 || end > 24) { lblResult.Text = "End time must be between 1 and 24."; return; }
        if (start >= end) { lblResult.Text = "Start time must be less than end time."; return; }

        int total = 0;
        for (int hour = start; hour < end; hour++)
            total += RateForHour(hour);

        lblResult.ForeColor = Color.DarkGreen;
        lblResult.Text = $"Rental: {start}h to {end}h ({end - start} hour(s))\nTotal to pay: {total:N0} RWF";
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();   // returns to Menu
    }
}
