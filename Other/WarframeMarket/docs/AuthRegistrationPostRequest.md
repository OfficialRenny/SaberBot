# WarframeMarket.Model.AuthRegistrationPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthType** | **string** |  | [optional] [default to AuthTypeEnum.Cookie]
**Email** | **string** |  | 
**Password** | **string** |  | 
**PasswordSecond** | **string** |  | 
**Region** | **string** |  | [optional] [default to "en"]
**DeviceId** | **string** | Optional device_id, defined on client side. This param help us to keep push subscription between login and logout. And clearer identify your device. | [optional] 
**Recaptcha** | **string** | Google reCaptcha, required if you are not using special device auth. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

