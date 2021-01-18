using DevExpress.Utils.MVVM.UI;
using DevExpress.XtraEditors;
using WinForms.MVVM.ViewModels;

namespace WinForms.MVVM.Views {
    [ViewType("EditCustomerView")]
    public partial class EditCustomerView : XtraForm {
        public EditCustomerView() {
            InitializeComponent();
            if(!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluentApi = mvvmContext1.OfType<EditCustomerViewModel>();
            fluentApi.SetBinding(CustomerBindingSource, bs => bs.DataSource, x => x.Customer);
            //
            fluentApi.BindCommand(btnSave, x => x.Save());
            fluentApi.BindCommand(btnReload, x => x.Reload());
        }
    }
}
