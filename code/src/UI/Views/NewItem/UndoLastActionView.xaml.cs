﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using Microsoft.Templates.UI.ViewModels.NewItem;
using System.Windows;

namespace Microsoft.Templates.UI.Views.NewItem
{
    /// <summary>
    /// Interaction logic for NewItemView.xaml
    /// </summary>
    public partial class UndoLastActionView : Window
    {
        public UndoLastActionViewModel ViewModel { get; }

        public CompareResult Result { get; set; }

        public UndoLastActionView()
        {
            ViewModel = new UndoLastActionViewModel(this);
            DataContext = ViewModel;
            Loaded += NewItemViewModel_Loaded;
            InitializeComponent();
        }
        private async void NewItemViewModel_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.InitializeAsync();

        }
    }
}
