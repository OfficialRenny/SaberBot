# Destiny.Model.DestinyComponentsKiosksDestinyKiosksComponent
A Kiosk is a Vendor (DestinyVendorDefinition) that sells items based on whether you have already acquired that item before.  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the individual character's DestinyCharacterKiosksComponent.  Note that, because this component returns vendorItemIndexes (that is to say, indexes into the Kiosk Vendor's itemList property), these results are necessarily content version dependent. Make sure that you have the latest version of the content manifest databases before using this data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KioskItems** | **Dictionary&lt;string, List&lt;DestinyComponentsKiosksDestinyKioskItem&gt;&gt;** | A dictionary keyed by the Kiosk Vendor&#39;s hash identifier (use it to look up the DestinyVendorDefinition for the relevant kiosk vendor), and whose value is a list of all the items that the user can \&quot;see\&quot; in the Kiosk, and any other interesting metadata. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

