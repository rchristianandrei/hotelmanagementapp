// src/types/env.d.ts
declare namespace NodeJS {
  interface ProcessEnv {
    JWT_SECRET: string;
    // Add other environment variables here as needed
    // For example:
    // DB_HOST: string;
    // DB_USER: string;
  }
}
