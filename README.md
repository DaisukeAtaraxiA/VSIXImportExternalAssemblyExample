# Visual Studio Editor extension example to import an external assembly

This is an example of Visual Studio Editor extension to import an external assembly.

## To import an external assembly

1. Open the source extension.vsixmanifest file in the VSIX project.

1. On the **Assets** tab, add the external assembly as MefComponent.

    1. Click the **New** button

    1. In the **Type** list, choose the **Microsoft.VisualStudio.MefComponent**.

    1. In the **Source** list, choose the **A project in current solution**.

    1. In the **Project** list, choose the external assembly you want to import to the VSIX project.