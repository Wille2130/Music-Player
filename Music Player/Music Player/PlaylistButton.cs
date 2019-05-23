﻿using System.Windows;
using System.Windows.Controls;
using System;

namespace Music_Player
{
    class PlaylistButton
    {
        private Playlist myPlaylist;
        private StackPanel myPanel;
        private MainWindow myMainWindow;
        private GUIHandler myHandler;

        private PlaylistButton(Playlist aPlaylist, StackPanel aPanel, MainWindow aMainWindow, Button myButton, GUIHandler aHandler)
        {
            myPlaylist = aPlaylist;
            myPanel = aPanel;
            myMainWindow = aMainWindow;
            myHandler = aHandler;

            myButton.Click += ShowPlaylist;
        }

        /// <summary>
        /// Shows the playlist.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPlaylist(object sender, RoutedEventArgs e)
        {
            myHandler.SwapTab(GUIHandler.GUITab.PlaylistShowSongs);
            myPlaylist.ShowPlaylist();
        }

        /// <summary>
        /// Creates a button for a playlist.
        /// </summary>
        /// <param name="aPlaylist"></param>
        /// <param name="aPanel"></param>
        /// <param name="aMainWindow"></param>
        /// <param name="aHandler"></param>
        /// <returns></returns>
        public static PlaylistButton Create(Playlist aPlaylist, StackPanel aPanel, MainWindow aMainWindow, GUIHandler aHandler)
        {
            Button tempButton = new Button();
            tempButton.Width = 880;
            tempButton.Height = 25;
            tempButton.Content = aPlaylist.GetName;
            tempButton.VerticalAlignment = VerticalAlignment.Top;

            aPanel.Children.Add(tempButton);

            PlaylistButton playlistButton = new PlaylistButton(aPlaylist, aPanel, aMainWindow, tempButton, aHandler);
            return playlistButton;
        }
    }
}