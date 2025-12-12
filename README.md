# CategoryPrecdictAI

•	Created Directory.Build.props with shared properties (targeting net10.0, Nullable, ImplicitUsings, InvariantGlobalization, preview C# via LangVersion).

•	Removed the explicit TargetFramework from CategoryPrecdictAI.csproj so the central props applies.

# 🎯 Centralize package versions with CPM
**Overview**: Centralize package versions with CPM

•	If you will add additional projects, they’ll inherit net10.0 automatically from Directory.Build.props.
	Projects that require a different TFM can override TargetFramework.

#  Centralized package versions using MSBuild Central Package Management:

•	Created Directory.Packages.props to define package versions in one place.

•	Enabled central package management in Directory.Build.props:
•	Added <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>.

•	Removed explicit Version attributes from PackageReference in CategoryPrecdictAI.
	csproj so projects inherit the centralized versions.

	How it works
•	Directory.Packages.props defines <PackageVersion> items.
	Projects reference packages without versions and MSBuild supplies the version centrally.
•	To override a version for a specific project, you can add a Version attribute on that PackageReference or add a <PackageVersion> entry scoped to a subfolder.

