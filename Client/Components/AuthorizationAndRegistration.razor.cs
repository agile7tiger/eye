﻿using Blazored.LocalStorage;
using MemoryClient.Extensions;
using MemoryClient.Services;
using Identity.Models;
using Identity.ViewModels;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using System.Net.Http.Json;
namespace MemoryClient.Components;

public partial class AuthorizationAndRegistration
{
    private bool _isShowWrapper;
    private LoginViewModel _loginModel = new();
    private RegisterViewModel _registerModel = new();
    private ResetPasswordViewModel _resetPasswordModel = new();
    private ForgotPasswordViewModel _forgotPasswordModel = new();
    private ServerSideValidator _serverSideRegistrationValidator = new();
    private ServerSideValidator _serverSideResetPasswordValidator = new();
    private ServerSideValidator _serverSideAuthorizationValidator = new();
    private ServerSideValidator _serverSideForgotPasswordValidator = new();
    [Inject] public IJSRuntime JS { get; set; }
    [Inject] public NavigationManager Navigation { get; set; }
    [Inject] public ILocalStorageService LocalStorage { get; set; }
    [Inject] public ServerHttpClient ServerHttpClient { get; set; }
    [Inject] public ServerAuthenticationStateProvider AuthenticationStateProvider { get; set; }

    private async Task LoginToAccount()
    {
        var response = await ServerHttpClient.PostAsJsonAsync("api/account/login", _loginModel);

        if (response.IsSuccessStatusCode)
        {
            _loginModel = new LoginViewModel();
            ToggleVisibilityWrapper();
            var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponseModel>();
            var userInfo = new UserInfo() { Nickname = loginResponse.Nickname, Token = loginResponse.Token, RefreshToken = loginResponse.RefreshToken };
            await LocalStorage.SetItemAsync(userInfo);
            AuthenticationStateProvider.NotifyUserAuthentication(userInfo.Token);
        }

        await _serverSideAuthorizationValidator.DisplayMessagesAsync<ResponseModel>(response.Content);
    }

    private async Task CreateAccount()
    {
        var response = await ServerHttpClient.PostAsJsonAsync("api/account/register", _registerModel);

        if (response.IsSuccessStatusCode)
        {
            _registerModel = new RegisterViewModel();
            StateHasChanged();
        }

        await _serverSideRegistrationValidator.DisplayMessagesAsync<RegisterResponseModel>(response.Content);
    }

    private async Task ForgotPassword()
    {
        var response = await ServerHttpClient.PostAsJsonAsync("api/account/forgotPassword", _forgotPasswordModel);

        if (response.IsSuccessStatusCode)
        {
            _resetPasswordModel.Email = _forgotPasswordModel.Email;
            _forgotPasswordModel = new ForgotPasswordViewModel();
            StateHasChanged();
        }

        await _serverSideForgotPasswordValidator.DisplayMessagesAsync<RegisterResponseModel>(response.Content);
    }

    private async Task ResetPassword()
    {
        var response = await ServerHttpClient.PostAsJsonAsync("api/account/resetPassword", _resetPasswordModel);

        if (response.IsSuccessStatusCode == true)
        {
            _resetPasswordModel = new ResetPasswordViewModel();
            ToggleVisibilityWrapper();
        }

        await _serverSideResetPasswordValidator.DisplayMessagesAsync<ResponseModel>(response.Content);
    }

    private void ToggleVisibilityWrapper()
    {
        _isShowWrapper = !_isShowWrapper;
    }
}
