# .Net 平台上快速为 Revit 创建插件

[![Nuget](https://img.shields.io/nuget/vpre/xml.Revit.Templates?style=for-the-badge)](https://www.nuget.org/packages/xml.Revit.Templates)
[![Downloads](https://img.shields.io/nuget/dt/xml.Revit.Templates?style=for-the-badge)](https://www.nuget.org/packages/xml.Revit.Templates)
[![Last Commit](https://img.shields.io/github/last-commit/ZedMoster/xml.Revit.Templates/dev?style=for-the-badge)](https://github.com/ZedMoster/xml.Revit.Templates/commits/main)


该模板包含用于快速创建 Revit 附加命令的项目模板

推荐使用拓展包 `https://www.nuget.org/packages/xml.Revit.Toolkit`

## Installation

1. 安装 [.Net SDK](https://dotnet.microsoft.com/download)
2. 运行 `dotnet new install xml.Revit.Templates` 安装更新项目模板

安装完成后

启动 **Visual Studio 2022**

新建项目中找到 `xml.Revit.Templates` 模板输入项目名称完成项目创建

编译通过则安装完成并正确使用可以在这个模板下愉快的写代码咯

## code snipate

创建代码片段快速创建Revit命令

打开文件夹

`C:\Program Files\Microsoft Visual Studio\2022\Community\VC#\Snippets\2052\Visual C#`

在文件夹内新建 `xmlRevitCommand.snippet` 文件并粘贴下方全部内容到此文件中后保存

```xml
<?xml version="1.0" encoding="utf-8"?>
<CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
	<CodeSnippet Format="1.0.0">
		<Header>
			<Title>xmlRevitCmd</Title>
			<Shortcut>xmlRevitCmd</Shortcut>
			<Description>xml Revit Command 的代码片段</Description>
			<Author>xml</Author>
			<SnippetTypes>
				<SnippetType>Expansion</SnippetType>
				<SnippetType>SurroundsWith</SnippetType>
			</SnippetTypes>
		</Header>
		<Snippet>
			<Declarations>
				<Literal>
					<ID>name</ID>
					<ToolTip>请输入功能类名</ToolTip>
					<Default>Test</Default>
				</Literal>
			</Declarations>
			<Code Language="csharp"><![CDATA[
			namespace xml.Revit.AddIn
			{
				[Xml("输入功能名称")]
				[Transaction(TransactionMode.Manual)]
				public class Cmd$name$ : XmlExternalCommand
				{
					protected override void Execute(ref string message, ElementSet elements)
					{
						XmlDoc.Print(uidoc.Document.Title);
					}
				}
			}
			]]>
			</Code>
		</Snippet>
	</CodeSnippet>
</CodeSnippets>

```

重新启动 **Visual Studio 2022**

输入 `xmlRevitCommand`命令可快速创建Revit功能命令

<p align="left">
    <picture>
        <source media="(prefers-color-scheme: dark)" width="750" srcset="https://raw.githubusercontent.com/ZedMoster/xml.Revit.Templates/main/assets/xmlRevitCommand.gif">
        <img alt="xmlRevitCommand" width="750" src="https://raw.githubusercontent.com/ZedMoster/xml.Revit.Templates/main/assets/xmlRevitCommand.gif">
    </picture>
</p>