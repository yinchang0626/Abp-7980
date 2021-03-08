import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
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
    scope: 'offline_access YC',
  },
  apis: {
    default: {
      url: 'https://localhost:44344',
      rootNamespace: 'YC',
    },
  },
} as Environment;
