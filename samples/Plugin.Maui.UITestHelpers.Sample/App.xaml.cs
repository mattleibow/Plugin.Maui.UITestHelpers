﻿namespace Plugin.Maui.UITestHelpers.Sample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}