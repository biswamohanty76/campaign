// src/theme.js
import { ThemeApi, type GetthemebytenantidRequest } from '../openapi/apis';
import { inject, provide } from 'vue';

// Create an inject key for the theme colors
export const themeColorsKey = Symbol('themeColors');

export const defaultTheme = {
    dark: false,
    colors: {
        background: '#FFFFFF',
        surface: '#FFFFFF',
        primary: '#009000',
        'primary-darken-1': '#3700B3',
        secondary: '#03DAC6',
        'secondary-darken-1': '#018786',
        error: '#B00020',
        info: '#2196F3',
        success: '#4CAF50',
        warning: '#FB8C00',
    }
}

export async function fetchThemeColors(tenant: any) {
    const themeApi = new ThemeApi();
    const request: GetthemebytenantidRequest = {
        guid: tenant,
    };

    try {
        const response = await themeApi.getthemebytenantid(request);
        const fetchedTheme = response;

        // Merge the fetched theme colors with the default theme
        const mergedTheme = {
            ...defaultTheme,
            ...fetchedTheme,
        };

        return mergedTheme;
    } catch (error) {
        console.error('Error fetching theme colors:', error);
        return defaultTheme; // Use the default theme in case of error
    }
}
// Provide the fetchThemeColors function globally
export function provideThemeColors() {
    provide(themeColorsKey, fetchThemeColors);
}

// Inject the fetchThemeColors function in components
export function useThemeColors() {
    const fetchThemeColors = inject(themeColorsKey);
    if (!fetchThemeColors) {
        throw new Error('fetchThemeColors function not provided');
    }
    return fetchThemeColors;
}
