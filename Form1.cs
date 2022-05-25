namespace SLT_data_balance
{
    public partial class main_form : Form
    {
        Calculate calculate = new Calculate();
        public main_form()
        {
            InitializeComponent();
            main_page_error_provider.SetIconPadding(std_usage, 5);
            main_page_error_provider.SetIconPadding(tot_usage, 5);
            clear_button.Enabled = false;
        }

        // Validations
        // Standard usage
        private void std_usage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            } else
            {
                e.Handled = false;
                main_page_error_provider.Clear();
            }
        }

        // Total usage
        private void tot_usage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                main_page_error_provider.Clear();
            }
        }

        private void package_MouseClick(object sender, MouseEventArgs e)
        {
            main_page_error_provider.Clear();
        }

        // on submit
        private void calculate_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(std_usage.Text))
            {
                std_usage.Focus();
                main_page_error_provider.SetError(std_usage, "Can't leave empty!");
            } else if (string.IsNullOrEmpty(tot_usage.Text))
            {
                tot_usage.Focus();
                main_page_error_provider.SetError(tot_usage, "Can't leave empty!");
            } else if (string.IsNullOrEmpty(package.Text))
            {
                package.Focus();
                main_page_error_provider.SetError(package, "Can't leave empty!");
            }
            else
            {
                main_page_error_provider.Clear();
                clear_button.Enabled = true;
                DialogResult rs = MessageBox.Show("Do you sure you want to calculate?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(rs == DialogResult.Yes)
                {
                    // Calculation
                    Result result = calculate.calculateRemaining(double.Parse(std_usage.Text), double.Parse(tot_usage.Text), package.Text);

                    day_remaining.Text = result.getDayRemaining().ToString();
                    night_remaining.Text=result.getNightRemaining().ToString();
                }
            }
        }

        // Clear button operation
        private void clear_button_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you want to clear all the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                std_usage.Clear();
                tot_usage.Clear();
                package.ResetText();
                day_remaining.Clear();
                night_remaining.Clear();
            }
        }
    }
}