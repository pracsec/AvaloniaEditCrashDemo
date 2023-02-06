using AvaloniaEdit.Document;
using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaEditCrashDemo.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        [Reactive]
        public TextDocument Documentation {
            get;
            set;
        } = new TextDocument(string.Empty);

        public string DocumentationText {
            get { return this.Documentation.Text; }
            set { this.Documentation.Text = value; }
        }

        public MainWindowViewModel() {
            this.DocumentationText = "Welcome!";
        }
    }
}
