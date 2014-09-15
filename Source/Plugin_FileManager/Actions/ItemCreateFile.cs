﻿using System;
using System.IO;
using Eto.Forms;
using Plugin_FileManager.Interface;
using Plugin_FileManager.Model;

namespace Plugin_FileManager.Actions
{
	public class ItemCreateFile : Command
	{
		private Status _status;
		public ItemCreateFile(Status status)
		{
			ID = "createFile";
			MenuText = "CreateFile";
			Executed += ItemCreateFile_Executed;

			_status = status;
		}

		void ItemCreateFile_Executed(object sender, EventArgs e)
		{
			string newFile = _status.CurrentDirPath+ _status.PathSeparator+"NewFile.txt";
			var fileEditer = new FileEditerSection(_status.Host, _status.ShellData, newFile, false);
			_status.Host.Ui.CreateNewTabPage("FileEdit", fileEditer);
		}
	}
}