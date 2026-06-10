using System.Security.Cryptography;

namespace GeradorEmail;

public partial class Form1 : Form
{
    private readonly AppConfig _config;

    public Form1()
    {
        InitializeComponent();

        _config = ConfigManager.Load();

        txtDomain.Text = _config.Domain;
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
        string email = $"{RandomHex(8)}@{txtDomain.Text.Trim()}";

        txtEmail.Text = email;

        Clipboard.SetText(email);

        lblStatus.Text = "✓ Copiado para a área de transferência";
    }

    private void btnCopiar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEmail.Text)) return;

        Clipboard.SetText(txtEmail.Text);

        lblStatus.Text = "✓ Copiado para a área de transferência";
    }

    private void btnSalvar_CLick(object sender, EventArgs e) 
    {
        _config.Domain = txtDomain.Text.Trim();

        ConfigManager.Save(_config);

        lblStatus.Text = "✓ Domínio salvo";
    }
}