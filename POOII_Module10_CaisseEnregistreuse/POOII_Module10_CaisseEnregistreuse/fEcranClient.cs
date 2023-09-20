namespace POOII_Module10_CaisseEnregistreuse
{
    public partial class fEcranClient : Form
    {
        private FactureModel m_factureModel;

        public fEcranClient(FactureModel p_factureModel)
        {
            InitializeComponent();
           m_factureModel = p_factureModel;

            new ObservateurFactureModel(
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