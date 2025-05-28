namespace CriAddon
{
 public partial class Form1 : Form
 {
	public Form1()
	{
	 InitializeComponent();

	 // Carrega default.txt no tb_result
	 string caminho = "templates/default.txt";
	 if (File.Exists(caminho))
	 {
		tb_result.Text = File.ReadAllText(caminho);
		loga("Default carregado.");
	 }
	 else
	 {
		loga("Nenhum default encontrado.");
	 }
	}

	// ----------------------------------------
	// POSICIONA A JANELA USANDO CONFIG SALVA
	// ----------------------------------------
	protected override void OnShown(EventArgs e)
	{
	 base.OnShown(e);

	 if (File.Exists("CriAddon.cfg"))
	 {
		string[] linhas = File.ReadAllLines("CriAddon.cfg");
		if (linhas.Length >= 2 &&
			int.TryParse(linhas[0], out int left) &&
			int.TryParse(linhas[1], out int top))
		{
		 this.Left = left;
		 this.Top = top;
		}
	 }
	}



	//-------------------------------------------
	// MÉTODOS
	//-------------------------------------------
	void loga(string txt)
	{
	 // adiciona texto no log com quebra de linha
	 tb_log.AppendText(txt + Environment.NewLine);


	}
	//--------------------------------------------
	void bt_save_default_Click(object sender, EventArgs e)
	{
	 string pasta = "templates";                     // nome da pasta
	 string caminho = Path.Combine(pasta, "default.txt"); // caminho completo do arquivo

	 if (!Directory.Exists(pasta))                  // verifica se pasta existe
		Directory.CreateDirectory(pasta);          // cria a pasta se necessário
	 File.WriteAllText(caminho, tb_result.Text);     // salva o conteúdo da textbox no arquivo
	 loga("Default salvo.");               // loga a mensagem
	}
	// BOTAO SAVE CONFIG 
	private void button8_Click(object sender, EventArgs e)
	{
	 // salva posição da janela no arquivo de config
	 string[] linhas = {
		this.Left.ToString(),
		this.Top.ToString()
	};

	 string caminho = Path.Combine(Application.StartupPath, "CriAddon.cfg");
	 File.WriteAllLines(caminho, linhas);
	 loga("Configuração salva."); // loga a mensagem
	}
 }
}
