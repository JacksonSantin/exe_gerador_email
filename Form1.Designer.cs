namespace GeradorEmail;

partial class Form1
{
    private TextBox txtEmail;
    private TextBox txtDomain;

    private Button btnGerar;
    private Button btnCopiar;
    private Button btnSalvar;

    private Label lblStatus;

    private void InitializeComponent()
    {
        txtEmail = new TextBox();
        txtDomain = new TextBox();

        btnGerar = new Button();
        btnCopiar = new Button();
        btnSalvar = new Button();

        lblStatus = new Label();

        SuspendLayout();

        BackColor = Color.FromArgb(32, 32, 32);

        ForeColor = Color.White;

        ClientSize = new Size(600, 260);

        Text = "Gerador de E-mail";

        FormBorderStyle =
            FormBorderStyle.FixedSingle;

        MaximizeBox = false;

        StartPosition =
            FormStartPosition.CenterScreen;

        txtEmail.Location =
            new Point(30, 30);

        txtEmail.Size =
            new Size(530, 30);

        txtEmail.ReadOnly = true;

        txtEmail.BackColor =
            Color.FromArgb(50, 50, 50);

        txtEmail.ForeColor =
            Color.White;

        txtDomain.Location =
            new Point(30, 80);

        txtDomain.Size =
            new Size(530, 30);

        txtDomain.BackColor =
            Color.FromArgb(50, 50, 50);

        txtDomain.ForeColor =
            Color.White;

        btnGerar.Location =
            new Point(30, 140);

        btnGerar.Size =
            new Size(150, 40);

        btnGerar.Text =
            "Gerar";

        btnGerar.Click +=
            btnGerar_Click;

        btnCopiar.Location =
            new Point(210, 140);

        btnCopiar.Size =
            new Size(150, 40);

        btnCopiar.Text =
            "Copiar";

        btnCopiar.Click +=
            btnCopiar_Click;

        btnSalvar.Location =
            new Point(390, 140);

        btnSalvar.Size =
            new Size(170, 40);

        btnSalvar.Text =
            "Salvar Domínio";

        btnSalvar.Click +=
            btnSalvar_Click;

        lblStatus.Location =
            new Point(30, 205);

        lblStatus.AutoSize = true;

        Controls.Add(txtEmail);
        Controls.Add(txtDomain);

        Controls.Add(btnGerar);
        Controls.Add(btnCopiar);
        Controls.Add(btnSalvar);

        Controls.Add(lblStatus);

        ResumeLayout(false);
        PerformLayout();
    }
}