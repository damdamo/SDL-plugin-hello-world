﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Extensions;
using System;
using System.Collections.Generic;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

using Sdl.Core.PluginFramework;
using Sdl.Core.Settings;

using Ribbon.HelloWorld;

namespace TestPluginWindowHello
{
	/// <summary>
	/// The action for applying a studio project template
	/// </summary>
	[Action("ApplicationHelloWorld", Icon = "Hello", Name = "Hello World !", Description = "Just Print Hello world when clicking on the button")]
	[ActionLayout(typeof(HelloWorldTemplateRibbonGroup), 10, DisplayType.Large)]
	[ActionLayout(typeof(TranslationStudioDefaultContextMenus.ProjectsContextMenuLocation), 10, DisplayType.Large)]
	[Shortcut(Keys.Control | Keys.Alt | Keys.T)]
	//class ApplyStudioProjectTemplateAction: AbstractAction
	class ApplyStudioProjectTemplateAction : AbstractViewControllerAction<ProjectsController>
	{
		protected override void Execute()
		{
			//MessageBox.Show("My icon and shortcut key action sample YOUPI.");
			var applyTemplateForm = new FormClickHere();
			applyTemplateForm.Show();

		}

	}
}
