import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'YC',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44344',
    redirectUri: baseUrl,
    clientId: 'YC_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone YC',
  },
  apis: {
    default: {
      url: 'https://localhost:44344',
      rootNamespace: 'YC',
    },
  },
} as Environment;
