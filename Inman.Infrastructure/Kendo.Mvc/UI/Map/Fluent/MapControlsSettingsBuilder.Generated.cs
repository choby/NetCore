using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapControlsSettings
    /// </summary>
    public partial class MapControlsSettingsBuilder
        
    {
        /// <summary>
        /// Configures or disables the built-in attribution control.
        /// </summary>
        /// <param name="configurator">The configurator for the attribution setting.</param>
        public MapControlsSettingsBuilder Attribution(Action<MapControlsAttributionSettingsBuilder> configurator)
        {
            Container.Attribution.Enabled = true;

            Container.Attribution.Map = Container.Map;
            configurator(new MapControlsAttributionSettingsBuilder(Container.Attribution));

            return this;
        }

        /// <summary>
        /// Configures or disables the built-in attribution control.
        /// </summary>
        /// <param name="enabled">Enables or disables the attribution option.</param>
        public MapControlsSettingsBuilder Attribution(bool enabled)
        {
            Container.Attribution.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Configures or disables the built-in navigator control (directional pad).
        /// </summary>
        /// <param name="configurator">The configurator for the navigator setting.</param>
        public MapControlsSettingsBuilder Navigator(Action<MapControlsNavigatorSettingsBuilder> configurator)
        {
            Container.Navigator.Enabled = true;

            Container.Navigator.Map = Container.Map;
            configurator(new MapControlsNavigatorSettingsBuilder(Container.Navigator));

            return this;
        }

        /// <summary>
        /// Configures or disables the built-in navigator control (directional pad).
        /// </summary>
        /// <param name="enabled">Enables or disables the navigator option.</param>
        public MapControlsSettingsBuilder Navigator(bool enabled)
        {
            Container.Navigator.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Configures or disables the built-in zoom control (+/- button).
        /// </summary>
        /// <param name="configurator">The configurator for the zoom setting.</param>
        public MapControlsSettingsBuilder Zoom(Action<MapControlsZoomSettingsBuilder> configurator)
        {
            Container.Zoom.Enabled = true;

            Container.Zoom.Map = Container.Map;
            configurator(new MapControlsZoomSettingsBuilder(Container.Zoom));

            return this;
        }

        /// <summary>
        /// Configures or disables the built-in zoom control (+/- button).
        /// </summary>
        /// <param name="enabled">Enables or disables the zoom option.</param>
        public MapControlsSettingsBuilder Zoom(bool enabled)
        {
            Container.Zoom.Enabled = enabled;
            return this;
        }

    }
}
