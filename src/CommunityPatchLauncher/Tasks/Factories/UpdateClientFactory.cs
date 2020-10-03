﻿using CommunityPatchLauncher.Commands.ApplicationWindow;
using CommunityPatchLauncher.Enums;
using CommunityPatchLauncher.Settings.Factories;
using CommunityPatchLauncher.Tasks.Update;
using CommunityPatchLauncherFramework.Settings.Factories;
using CommunityPatchLauncherFramework.Settings.Manager;
using CommunityPatchLauncherFramework.TaskPipeline.Factory;
using CommunityPatchLauncherFramework.TaskPipeline.Tasks;
using CommunityPatchLauncherFramework.TaskPipeline.Tasks.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommunityPatchLauncher.Tasks.Factories
{
    public class UpdateClientFactory : ITaskFactory
    {
        private readonly SettingManager manager;
        private readonly UpdateBranchEnum updateBranch;
        private readonly Window parentWindow;

        public UpdateClientFactory(UpdateBranchEnum updateBranch, Window parentWindow)
        {
            ISettingFactory factory = new WpfPropertySettingManagerFactory();
            manager = factory.GetSettingsManager();
            this.updateBranch = updateBranch;
            this.parentWindow = parentWindow;
        }

        public List<ITask> GetTasks()
        {
            List<ITask> tasks = new List<ITask>();
            string settingToLoad = "ReleaseFilter";
            ITask localVersionTask = new GetLocalVersion();
            if (updateBranch == UpdateBranchEnum.Develop)
            {
                settingToLoad = "DevelopFilter";
                localVersionTask = new GetLocalVersionFromSettings();
            }

            string repositoryOwner = manager.GetValue<string>("ReporistoryOwner");
            string repositoryName = manager.GetValue<string>("RepositoryName");
            string releaseFilter = manager.GetValue<string>(settingToLoad);
            string patchLauncher = manager.GetValue<string>("PatchAppName");

            tasks.Add(localVersionTask);
            tasks.Add(new GetGitHubVersion(repositoryOwner, repositoryName, releaseFilter));
            tasks.Add(new UpdatePopupTask(parentWindow));
            tasks.Add(new DownloadLauncherUpdate());
            if (updateBranch == UpdateBranchEnum.Develop)
            {
                tasks.Add(new WriteCurrentVersionToSettings());
            }
            tasks.Add(new PatchLauncher(patchLauncher));
            tasks.Add(new CloseApplicationTask(new CloseApplicationCommand()));
            return tasks;
        }
    }
}
