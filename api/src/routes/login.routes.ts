import { Router } from "express";
import { LoginController } from "../controllers/login.controller";

const router: Router = Router();

// #region Create / Update
router.post("/", LoginController.GenJWT);
// #endregion
export default router;
