using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MyHomework_張佑晨.Properties
{
	// Token: 0x02000011 RID: 17
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000099 RID: 153 RVA: 0x0000FF17 File Offset: 0x0000E117
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000FF24 File Offset: 0x0000E124
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("MyHomework_張佑晨0708.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000FF6C File Offset: 0x0000E16C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000FF83 File Offset: 0x0000E183
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040000FC RID: 252
		private static ResourceManager resourceMan;

		// Token: 0x040000FD RID: 253
		private static CultureInfo resourceCulture;
	}
}
