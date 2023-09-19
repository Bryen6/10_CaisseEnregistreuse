namespace POOII_Module10_CaisseEnregistreuse
{
    public partial class fEcranClient : Form
    {
        private ObservateurFactureModel m_observateurClient;
        private FactureModel m_factureModel;

        public ObservateurFactureModel ObservateurClient
        {
            get { return m_observateurClient; }
        }

        public fEcranClient()
        {
            InitializeComponent();
            m_factureModel = new FactureModel();

            m_observateurClient = new ObservateurFactureModel(
                m_factureModel,
                value =>
                {
                    if (value.Type == TypeEvenementFactureModel.AJOUT_LIGNE)
                    {
                        string tbClient = $"{value.LigneFactureModel.Description}\t " +
                                            $"{value.LigneFactureModel.Quantite} @\t " +
                                            $"{value.LigneFactureModel.PrixUnitaire} $";

                        this.tb_ecranClient.Text = tbClient;

                    }
                    else if (value.Type == TypeEvenementFactureModel.NOUVELLE)
                    {
                        this.tb_ecranClient.Text = "Bienvenue";
                    }
                }
            );
        }
    }
}