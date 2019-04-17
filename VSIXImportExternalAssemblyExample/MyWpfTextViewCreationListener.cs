using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace VSIXImportExternalAssemblyExample
{
    [ContentType("code")]
    [Export(typeof(IWpfTextViewCreationListener))]
    [TextViewRole(PredefinedTextViewRoles.Editable)]
    [Name("MyWpfTextViewCreationListener")]
    class MyWpfTextViewCreationListener : IWpfTextViewCreationListener
    {
        [ImportingConstructor]
        public MyWpfTextViewCreationListener(ExternalClassLibrary.Class1 clazz)
        {
            clazz.Foo();
        }

        public void TextViewCreated(IWpfTextView textView)
        {
        }
    }
}
