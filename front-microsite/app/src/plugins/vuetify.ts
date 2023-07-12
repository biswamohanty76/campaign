// Styles
import '@mdi/font/css/materialdesignicons.css'
import 'vuetify/styles'

// Vuetify
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as labsComponents from 'vuetify/labs/components'
import type { ThemeConfiguration } from '@/openapi/models'
import { ThemeApi } from '@/openapi'
import { useRoute, useRouter } from 'vue-router'
var themApi = new  ThemeApi();



const myCustomLightTheme = {
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

export async function createCustomVuetify(route:any) {
  let themeConfig = {};

  try {
    themeConfig = await fetchThemeConfig(route);
  } catch (error) {
    console.log('Failed to fetch theme configuration:', error);
  }

  return createVuetify({
    components: {
      ...components,
      ...labsComponents,
    },
    theme: {
      defaultTheme: 'myCustomLightTheme',
      themes: {
        myCustomLightTheme: {
          ...myCustomLightTheme,
          ...themeConfig, // Merge the fetched theme configuration with the default theme
        },
      },
    },
  });
}

async function fetchThemeConfig(route: any): Promise<ThemeConfig> {
  try {
    if (route.params.id !== undefined) {
      var tenantId = route.params.id.toString();
      return themApi.getthemebytenantid({ guid: tenantId })
        .then((response) => {
          return mapThemeConfigurationToThemeConfig(response); // Call a function to map the response to the theme configuration
        })
        .catch(error => {
          console.log(error);
          throw error;
        });
    } else {
      // Handle the case when tenant ID is not defined
      throw new Error('Tenant ID is undefined');
    }
  } catch (error) {
    console.log('Error fetching theme configuration:', error);
    // You can handle the error as per your application's requirements
    throw error;
  }
}

export interface ThemeConfig {
  dark: boolean;
  colors: {
    background: string;
    surface: string;
    primary: string;
    'primary-darken-1': string;
    secondary: string;
    'secondary-darken-1': string;
    error: string;
    info: string;
    success: string;
    warning: string;
  };
}

function mapThemeConfigurationToThemeConfig(themeConfiguration: ThemeConfiguration): ThemeConfig {
  const themeConfig: ThemeConfig = {
    dark: false,
    colors: {
      background: themeConfiguration.background || '#FFFFFF',
      surface: themeConfiguration.surface || '#FFFFFF',
      primary: themeConfiguration.primary || '#009000',
      'primary-darken-1': themeConfiguration.primaryDarken1 || '#3700B3',
      secondary: themeConfiguration.secondary || '#03DAC6',
      'secondary-darken-1': themeConfiguration.secondaryDarken1 || '#018786',
      error: themeConfiguration.error || '#B00020',
      info: themeConfiguration.info || '#2196F3',
      success: themeConfiguration.success || '#4CAF50',
      warning: themeConfiguration.warning || '#FB8C00',
    },
  };

  return themeConfig;
}


