import { Router } from "express";
import { verifyToken } from "../../middlewares/verification.middleware";
import { RecordsController } from "./records.controller";

const router: Router = Router();

// #region Create / Update
router.post("/", verifyToken, RecordsController.Save);
// #endregion

// #region Read
router.get("/", verifyToken, RecordsController.Get1000);
// #endregion

export default router;
