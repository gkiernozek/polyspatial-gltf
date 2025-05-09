using UnityEngine;

namespace PolySpatial.Samples
{
    public class LevelData : MonoBehaviour
    {
        public enum LevelTypes
        {
            CharacterNavigation,
            TargetedInput,
            ImageTracking,
            ObjectManipulation,
            SpatialUI,
            InputDebug,
            MixedReality,
            SwiftUI,
            Meshing,
            UGUI,
            Portal,
            Particles,
            Lights,
            Blendshapes,
            ResizeVolume,
            Billboard,
            ObjectTracking
        }

        const string CharacterNavigationTitle = "Character Navigation";
        const string TargetedInputTitle = "Targeted Input";
        const string ImageTrackingTitle = "Image Tracking";
        const string ObjectTrackingTitle = "Object Tracking";
        const string ObjectManipulationTitle = "Object Manipulation";
        const string SpatialUITitle = "Spatial UI";
        const string InputDebugTitle = "Input Debug";
        const string MixedRealityTitle = "Mixed Reality";
        const string SwiftUITitle = "Swift UI";
        const string MeshingTitle = "Meshing";
        const string UGUITitle = "uGUI";
        const string PortalTitle = "Portal";
        const string ParticlesTitle = "Particles";
        const string LightsTitle = "Lights";
        const string BlendshapesTitle = "Blendshapes";
        const string ResizeVolumeTitle = "Resizable Volumes";
        const string BillboardTitle = "Billboard Component";

        const string CharacterNavigationDescription = "Scene demonstrating a character navigating around with a dynamic camera in a bounded volume.";

        const string TargetedInputDescription =
            "Scene demonstrating targeted input and particle systems through the use of a simple balloon gallery mini game.";

        const string ImageTrackingDescription = "Scene demonstrating spawning content relative to unique tracked images in an unbounded space.";
        const string ObjectTrackingDescription = "Scene demonstrating spawning content relative to unique tracked ojbect in an unbounded space.";
        const string ObjectManipulationDescription = "Scene demonstrating manipulating 3D assets within a bounded volume using XRI.";
        const string SpatialUIDescription = "Scene demonstrating interactions with common spatial UI elements within a bounded volume.";
        const string InputDebugDescription = "Scene displaying input data generated from direct and indirect touches within a bounded volume.";
        const string MixedRealityDescription = "Scene demonstrating an unbounded app that displays AR Plane data and uses a custom ARKit hand gesture.";
        const string SwiftUIDescription = "Scene demonstrating interop with SwiftUI.";
        const string MeshingDescription = "Scene showing ARKit mesh capabilities with unique ways to render the mesh.";
        const string UGUIDescription = "Scene demonstrating a UI setup with uGUI components.";
        const string PortalDescription = "Scene demonstrating a portal effect using Occlusion Material";
        const string ParticlesDescription = "Scene with a Unity particle system, it supports both replicate properties and bake to mesh.";
        const string LightsDescription = "Scene demonstrating dynamic lighting with point and directional lights.";
        const string BlendshapesDescription = "Scene demonstrating blendshapes";
        const string ResizeVolumeDescription = "Scene demonstrating a resizable volume and settings";
        const string BillboardDescription = "Scene demonstrating a billboard component";

        public string GetLevelTitle(LevelTypes levelType)
        {
            switch (levelType)
            {
                case LevelTypes.CharacterNavigation:
                    return CharacterNavigationTitle;
                case LevelTypes.TargetedInput:
                    return TargetedInputTitle;
                case LevelTypes.ImageTracking:
                    return ImageTrackingTitle;
                case LevelTypes.ObjectManipulation:
                    return ObjectManipulationTitle;
                case LevelTypes.SpatialUI:
                    return SpatialUITitle;
                case LevelTypes.InputDebug:
                    return InputDebugTitle;
                case LevelTypes.MixedReality:
                    return MixedRealityTitle;
                case LevelTypes.SwiftUI:
                    return SwiftUITitle;
                case LevelTypes.Meshing:
                    return MeshingTitle;
                case LevelTypes.UGUI:
                    return UGUITitle;
                case LevelTypes.Portal:
                    return PortalTitle;
                case LevelTypes.Particles:
                    return ParticlesTitle;
                case LevelTypes.Lights:
                    return LightsTitle;
                case LevelTypes.Blendshapes:
                    return BlendshapesTitle;
                case LevelTypes.ResizeVolume:
                    return ResizeVolumeTitle;
                case LevelTypes.Billboard:
                    return BillboardTitle;
                case LevelTypes.ObjectTracking:
                    return ObjectTrackingTitle;
                default:
                    return "";
            }
        }

        public string GetLevelDescription(LevelTypes levelType)
        {
            switch (levelType)
            {
                case LevelTypes.CharacterNavigation:
                    return CharacterNavigationDescription;
                case LevelTypes.TargetedInput:
                    return TargetedInputDescription;
                case LevelTypes.ImageTracking:
                    return ImageTrackingDescription;
                case LevelTypes.ObjectTracking:
                    return ObjectTrackingDescription;
                case LevelTypes.ObjectManipulation:
                    return ObjectManipulationDescription;
                case LevelTypes.SpatialUI:
                    return SpatialUIDescription;
                case LevelTypes.InputDebug:
                    return InputDebugDescription;
                case LevelTypes.MixedReality:
                    return MixedRealityDescription;
                case LevelTypes.SwiftUI:
                    return SwiftUIDescription;
                case LevelTypes.Meshing:
                    return MeshingDescription;
                case LevelTypes.UGUI:
                    return UGUIDescription;
                case LevelTypes.Portal:
                    return PortalDescription;
                case LevelTypes.Particles:
                    return ParticlesDescription;
                case LevelTypes.Lights:
                    return LightsDescription;
                case LevelTypes.Blendshapes:
                    return BlendshapesDescription;
                case LevelTypes.ResizeVolume:
                    return ResizeVolumeDescription;
                case LevelTypes.Billboard:
                    return BillboardDescription;
                default:
                    return "";
            }
        }
    }
}
