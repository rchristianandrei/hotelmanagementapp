import { Router } from "express";
import { verifyToken } from "../middlewares/verification.middleware";
import { CheckInOutController } from "../controllers/checkInOut.controller";

const router: Router = Router();

// #region Create / Update
router.post("/:id/:hour", verifyToken, CheckInOutController.Save);
// #endregion

// #region Read
router.get("/", verifyToken, CheckInOutController.Get1000);
// #endregion

// #region Delete
router.delete("/:id", verifyToken, CheckInOutController.Delete);
// #endregion

export default router;
