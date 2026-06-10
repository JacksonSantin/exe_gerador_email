using System.Security.Cryptography;

namespace GeradorEmail;

public partial class Form1 : Form
{
    private readonly AppConfig _config;

    public Form1()
    {
        InitializeComponent();

        Font = new Font("Segoe UI", 10F);

        _config = ConfigManager.Load();

        txtDomain.Text = _config.Domain;

        lblStatus.Text = "";

        Text = $"Gerador de E-mail - {txtDomain.Text}";

        btnGerar.PerformClick();
    }

    private static string RandomHex(int bytes)
    {
        byte[] data = RandomNumberGenerator.GetBytes(bytes);

        return Convert
            .ToHexString(data)
            .ToLower();
    }

    private void btnGerar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtDomain.Text))
        {
            MessageBox.Show(
                "Informe um domínio válido.",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        string email = $"{RandomHex(8)}@{txtDomain.Text.Trim()}";

        txtEmail.Text = email;

        txtEmail.SelectAll();
        
        Clipboard.SetText(email);

        lblStatus.Text = "✓ Copiado para a área de transferência";

    }

    private async void btnCopiar_Click(
     object sender,
     EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEmail.Text))
            return;

        Clipboard.SetText(txtEmail.Text);

        string textoOriginal = btnCopiar.Text;

        btnCopiar.Text = "✓ Copiado";

        await Task.Delay(2000);

        btnCopiar.Text = textoOriginal;
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        _config.Domain = txtDomain.Text.Trim();

        ConfigManager.Save(_config);

        Text = $"Gerador de E-mail - {_config.Domain}";

        lblStatus.Text = "✓ Domínio salvo";
    }
}